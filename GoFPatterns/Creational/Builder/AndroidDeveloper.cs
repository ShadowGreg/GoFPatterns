namespace GoFPatterns.Creational.Builder {
    public class AndroidDeveloper: IDeveloper {
        private Phone newPhone;
        public AndroidDeveloper() => newPhone = new Phone();
        public void CreateDisplay() => newPhone.AppendData("Произведён дисплей Samsung");

        public void CreateBox() => newPhone.AppendData("Произведён корпус Samsung");

        public void SystemInstall() => newPhone.AppendData("Установлена система Android");

        public Phone GetPhone() => newPhone;
    }
}