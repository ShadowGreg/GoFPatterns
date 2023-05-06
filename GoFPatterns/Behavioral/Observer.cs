using System.Collections.Generic;
using System.Linq;

namespace GoFPatterns.Behavioral {
    public interface IObserver {
        string Update(double price);
        string ToString();
    }

    public interface IObservable {
        string AddObserver(IObserver observer);
        string RemoveObserver(IObserver observer);
        string Notify();
    }

    public class Product: IObservable {
        private readonly List<IObserver> _observers;
        private double _price;

        public Product(double price) {
            _price = price;
            _observers = new List<IObserver>();
        }

        public string ChangePrice(double newPrice) {
            _price = newPrice;
            return "Цена изменилась и стала " + newPrice + Notify();
        }


        public string AddObserver(IObserver observer) {
            _observers.Add(observer);
            return "За товаром наблюдает: " + observer.ToString();
        }

        public string RemoveObserver(IObserver observer) {
            _observers.Remove(observer);
            return observer.ToString() + " болше не следит за товаром";
        }

        public string Notify() {
            string message = string.Empty;
            foreach (IObserver observer in _observers.ToList()) {
                message += observer.Update(_price);
                message += " " + observer.ToString();
            }

            return message + " предупреждены об измении цены";
        }

        public override string ToString() => "Некий товар";
    }

    public class Wholesale: IObserver {
        private readonly IObservable _product;

        public Wholesale(IObservable product) {
            _product = product;
            product.AddObserver(this);
        }

        public string Update(double price) {
            if (!(price < 300)) return "Не подходящая цена на " + _product + " для " + this;
            _product.RemoveObserver(this);
            return this + " закупил " + _product;
        }

        public override string ToString() {
            return "Оптовик";
        }
    }

    public class Buyer: IObserver {
        private readonly IObservable _product;

        public Buyer(IObservable product) {
            _product = product;
            product.AddObserver(this);
        }

        public string Update(double price) {
            if (!(price < 350)) return "Не подходящая цена на " + _product + " для " + this;
            _product.RemoveObserver(this);
            return this + " закупил " + _product;
        }

        public override string ToString() {
            return "Покупатель";
        }
    }

    public class Observer { }
}