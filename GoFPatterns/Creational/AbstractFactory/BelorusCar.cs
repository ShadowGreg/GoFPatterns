namespace GoFPatterns.Creational.AbstractFactory {
    public class BelorusCar: ICar {
        public string ReleaseCar(IEngine engine) {
            return "Выпущен белорусский автомобиль: в котором установлен ->" + engine.ReleaseEngine();
        }
    }
}