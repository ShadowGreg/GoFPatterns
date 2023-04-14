namespace GoFPatterns.Creational.Builder {
    public class Phone {
        private string _data;
        public Phone() => _data = "";
        public string AboutPhone() => _data;
        public void AppendData(string data) => _data += data;
    }
}