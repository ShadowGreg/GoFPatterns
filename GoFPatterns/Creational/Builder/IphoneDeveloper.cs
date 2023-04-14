namespace GoFPatterns.Creational.Builder {
    public class IphoneDeveloper: IDeveloper {
        private Phone newPhone;
        public IphoneDeveloper() => newPhone = new Phone();
        public void CreateDisplay() => newPhone.AppendData("Произведён дисплей Iphone");

        public void CreateBox() => newPhone.AppendData("Произведён корпус Iphone");

        public void SystemInstall() => newPhone.AppendData("Установлена система Iphone");

        public Phone GetPhone() => newPhone;
    }
}