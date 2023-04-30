using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GoFPatterns.Behavioral {
    public interface ICommand {
        string Positive();
        string Negative();
    }

    public class Conveyor {
        public string On() => "Конвейер запущен. ";
        public string Off() => "Конвейер остановлен. ";
        public string IncreaseSpeed() => "Скорость конвейера увеличина. ";
        public string ReduceSpeed() => "Скорость конвейера понижена. ";
    }

    public class EnableDisableButtons: ICommand {
        private readonly Conveyor _conveyor;
        public EnableDisableButtons(Conveyor conveyor) => _conveyor = conveyor;

        public string Positive() => _conveyor.On();
        public string Negative() => _conveyor.Off();
    }

    public class ZoomButtonsDecreaseSpeed: ICommand {
        private readonly Conveyor _conveyor;
        public ZoomButtonsDecreaseSpeed(Conveyor conveyor) => _conveyor = conveyor;

        public string Positive() => _conveyor.IncreaseSpeed();
        public string Negative() => _conveyor.ReduceSpeed();
    }

    public class СonveyorControlPanel {
        private readonly List<ICommand> _commands;
        private readonly Stack<ICommand> _history;

        public СonveyorControlPanel() {
            _commands = new List<ICommand>() { null, null };
            _history = new Stack<ICommand>();
        }

        public void SetCommand(int numButton, ICommand command) => _commands[numButton] = command;

        public string PressOn(int button) {
            _history.Push(_commands[button]);
            return _commands[button].Positive();
        }

        public string PressCancel() {
            return _history.Count != 0 ? _history.Pop().Negative() : string.Empty;
        }
    }

    public class Command { }
}