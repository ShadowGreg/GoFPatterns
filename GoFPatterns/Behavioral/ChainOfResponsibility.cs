using System;

namespace GoFPatterns.Behavioral {
    public interface IWorker {
        IWorker SetNextWorker(IWorker worker);
        string Execute(string command);
    }

    public abstract class AbsWorker: IWorker {
        private IWorker _nextWorker;
        public AbsWorker() => _nextWorker = null;

        public IWorker SetNextWorker(IWorker worker) {
            _nextWorker = worker;
            return worker;
        }

        public virtual string Execute(string command) {
            return _nextWorker != null ? _nextWorker.Execute(command) : string.Empty;
        }
    };

    public partial class Designer: AbsWorker {
        public override string Execute(string command) {
            if (command == "спроектировать дом")
                return "Проектировщик выполнил команду: " + command;
            return base.Execute(command);
        }
    }

    public class Mason: AbsWorker {
        public override string Execute(string command) {
            if (command == "класть керпичь")
                return "Каменщик выполнил команду: " + command;
            return base.Execute(command);
        }
    }


    public class Plasterer: AbsWorker {
        public override string Execute(string command) {
            if (command == "штукатурить стены")
                return "Штукатур выполнил команду: " + command;
            return base.Execute(command);
        }
    }

    public class Painter: AbsWorker {
        public override string Execute(string command) {
            if (command == "красить поверхности")
                return "Маляр выполнил команду: " + command;
            return base.Execute(command);
        }
    }

    public class Plumber: AbsWorker {
        public override string Execute(string command) {
            if (command == "подсоединить сантехнику")
                return "Сантехник выполнил команду: " + command;
            return base.Execute(command);
        }
    }

    public class Electrician: AbsWorker {
        public override string Execute(string command) {
            if (command == "подсоединить электрику")
                return "Электрик выполнил команду: " + command;
            return base.Execute(command);
        }
    }

    public class ChainOfResponsibility {
        
        public static string GiveCommand(IWorker worker, string command) {
            string str = worker.Execute(command);
            if (str == "")
                return command + " - никто не умеет этого делать";
            return str;
        }
    }
}