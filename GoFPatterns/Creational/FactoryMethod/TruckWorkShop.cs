namespace GoFPatterns.Creational.FactoryMethod
{
    public class TruckWorkShop : IWorkShop
    {
        public IProductions Create() => new Truck();
    }
}