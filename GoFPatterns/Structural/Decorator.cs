using System.Diagnostics;

namespace GoFPatterns.Structural {
    public interface IProcessor {
        string Process();
    }

    public class Transmitter: IProcessor {
        private readonly string _data;
        public Transmitter(string data) => _data = data;
        public string Process() => "Данные-> "+_data+" Переданы по каналу связи";
    }
    

    public abstract class Shell: IProcessor {
        protected IProcessor _processor;
        public Shell(IProcessor processor) => _processor = processor;
        public virtual string Process() => _processor.Process();
    }

    public class HammingCoder: Shell {
        public HammingCoder(IProcessor processor): base(processor) { }
        public override string Process() {
            return "Наложен помехоустойчивый код Хамминга-> "+base.Process();
        }
    }
    
    public class Encryptor: Shell {
        public Encryptor(IProcessor processor): base(processor) { }
        public override string Process() {
            return "Шифрование данных-> "+base.Process();
        }
    }

    public class Decorator {
        
    }
}