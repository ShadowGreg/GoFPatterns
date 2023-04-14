using System;

namespace GoFPatterns.Creational.FactoryMethod
{
    public class Car : IProductions
    {
        public void Realise() => Console.WriteLine("Выпущен новый легковой автомобиль");
    }
}