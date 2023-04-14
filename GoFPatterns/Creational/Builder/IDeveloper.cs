namespace GoFPatterns.Creational.Builder {
    public interface IDeveloper {
        void CreateDisplay();
        void CreateBox();
        void SystemInstall();
        Phone GetPhone();
    }
}