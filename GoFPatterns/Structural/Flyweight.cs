using System;
using System.Collections.Generic;

namespace GoFPatterns {
    public struct Shared {
        private readonly string _companyName;
        private readonly string _position;

        public Shared(string companyName, string position) {
            _companyName = companyName;
            _position = position;
        }

        public string CompanyName => _companyName;
        public string Position => _position;
    }

    public struct Unigue {
        private readonly string _name;
        private readonly string _passport;

        public Unigue(string name, string passport) {
            _name = name;
            _passport = passport;
        }

        public string Name => _name;
        public string Passport => _passport;
    }

    public class Flyweight {
        private readonly Shared _shared;
        public Flyweight(Shared shared) => _shared = shared;

        public string Process(Unigue unique) => "Обработаны новые данные: общие" + _shared.CompanyName + "_" +
                                                _shared.Position + " и уникальные " + unique.Name + "_" +
                                                unique.Passport;

        public string GetData() => _shared.CompanyName + "_" + _shared.Position;
    }

    public class FlyweightFactory {
        private Dictionary<string,Flyweight> _flyweights;
        private string GetKey(Shared shared) => shared.CompanyName + "_" + shared.Position;

        public FlyweightFactory(List<Shared> flyweights) {
            _flyweights = new Dictionary<string, Flyweight>();
            foreach (Shared item in flyweights) {
                _flyweights.Add(GetKey(item), new Flyweight(item));
            }
        }

        public Flyweight GetFlyweight(Shared shared) {
            string key = GetKey(shared);
            if (!_flyweights.ContainsKey(key)) {
                Console.WriteLine("Фабрика легковесов: Общий объект по ключу" + key + "не найден и добавлен в список.");
            }
            else {
                Console.WriteLine("Фабрика легковесов: извлечены данные по ключу " + key + ".");
            }

            return (Flyweight)_flyweights[key];
        }

        public string ListFlyweights() {
            int count = _flyweights.Count;
            string outData = "";
            Console.WriteLine("Фабрика легковесов: Всего " + count + " записей:");
            foreach (Flyweight flyweight in _flyweights.Values) {
                outData += flyweight.GetData()+" ";
            }

            return outData;
        }
    }
}