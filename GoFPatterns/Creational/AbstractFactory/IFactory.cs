namespace GoFPatterns.Creational.AbstractFactory {
    public interface IFactory {
        IEngine createEngine();
        ICar createCar();
    }
}