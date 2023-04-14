using System;

namespace GoFPatterns.Creational.FactoryMethod
{
    public class Truck : IProductions
    {
        public string Realise() => "Выпущен новый грузовой автомобиль";
    }
}