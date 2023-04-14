using System;

namespace GoFPatterns.Creational.FactoryMethod
{
    public class Car : IProductions
    {
        public string Realise() => "Выпущен новый легковой автомобиль";
    }
}