namespace GoFPatterns.Behavioral {
    public abstract class Transmitter {
        protected virtual string VoiceRecord() => "Запись фрагмента речи";
        protected virtual string Simpling() => string.Empty;
        protected virtual string Digitization() => string.Empty;
        protected virtual string Modulation() => string.Empty;
        protected virtual string Transmission() => "Передача сигнала по радиоканалу";

        public string ProcessStart() {
            string _msg = VoiceRecord() + Simpling() + Digitization() + Modulation() +
                          Transmission();
            return _msg;
        }
    }

    public class AnalogTransmitter: Transmitter {
        protected override string Modulation() => "Модуляция аналового сигнала";
    }

    public class DigitalTransmitter: Transmitter {
        protected override string Simpling() => "Модуляция аналового сигнала";
        protected override string Digitization() => "Модуляция аналового сигнала";
        protected override string Modulation() => "Модуляция аналового сигнала";
    }
    public class TemplateMethod { }
}