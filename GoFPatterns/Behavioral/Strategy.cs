namespace GoFPatterns.Behavioral {
    public interface IRender {
        string Parse(string url);
        string ToString();
    }

    public class ResourceReader {
        private IRender _reader;
        public ResourceReader(IRender reader) => _reader = reader;

        public string SetStrategy(IRender reader) {
            _reader = reader;
            return "Установлен сайт для чтения " + reader;
        }

        public string Read(string url) => _reader.Parse(url);
    }

    public class HeadHunterReader: IRender {
        public string Parse(string url) {
            return "Чтение информации с хэдхатер " + url;
        }
    }
    
    public class HarborReader: IRender {
        public string Parse(string url) {
            return "Чтение информации с харбор " + url;
        }
    }
    
    public class TelegramChannelReader: IRender {
        public string Parse(string url) {
            return "Чтение информации с телеграмм каналов " + url;
        }
    }
    public class Strategy { }
}