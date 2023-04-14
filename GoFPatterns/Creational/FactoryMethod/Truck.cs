using System;

namespace GoFPatterns.Creational.FactoryMethod
{
    public class Truck : IProductions
    {
        public void Realise() => Console.WriteLine("Выпущен новый грузовой автомобиль");
    }
}