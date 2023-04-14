namespace GoFPatterns.Creational.AbstractFactory {
    public class RussianCar: ICar {
        public string ReleaseCar(IEngine engine) {
            return "Выпущен российский автомобиль: в котором установлен ->" + engine.ReleaseEngine();
        }
    }
}