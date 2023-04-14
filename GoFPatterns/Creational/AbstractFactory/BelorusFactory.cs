namespace GoFPatterns.Creational.AbstractFactory {
    public class BelorusFactory: IFactory {
        public IEngine createEngine() => new BelorusEngine();
        public ICar createCar() => new BelorusCar();
    }
}