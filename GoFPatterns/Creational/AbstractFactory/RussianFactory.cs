namespace GoFPatterns.Creational.AbstractFactory {
    public class RussianFactory: IFactory {
        public IEngine createEngine() => new RussianEngine();
        public ICar createCar() => new RussianCar();
    }
}