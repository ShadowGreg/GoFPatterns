namespace GoFPatterns.Creational.FactoryMethod
{
    public class CarWorkShop : IWorkShop
    {
        public IProductions Create() => new Car();
    }
}