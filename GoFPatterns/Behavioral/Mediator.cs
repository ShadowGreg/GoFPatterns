namespace GoFPatterns.Behavioral {
    public interface IMediator {
        void Notify(Employee employee, string msg);
    }

    public abstract class Employee {
        protected IMediator _mediator;
        public Employee(IMediator mediator) => _mediator = mediator;
        public void SetMediator(IMediator mediator) => _mediator = mediator;
    }

    public class UXDesigner: Employee {
        private bool _isWorking;
        public UXDesigner(IMediator mediator = null): base(mediator) { }

        public string ExecuteWork() {
            _mediator.Notify(this, "UX дизайнер проектирует...");
            return "<-Дизайнер в работе";
        }

        public string SetWork(bool state = true) {
            _isWorking = state;
            return state ? "<-UX дизайнер занят" : "<-UX дизайнер свободен";
        }
    }

    public class ITDirector: Employee {
        private string _command;
        public ITDirector(IMediator mediator = null): base(mediator) { }

        public string GiveCommand(string command) {
            _command = command;
            _mediator.Notify(this, command);
            if (_command != string.Empty)
                return "-> Директор знает, что UX дизайнер в работе";
            return "" + _command;
        }
    }

    public class Mediator: IMediator {
        private readonly UXDesigner _designer;
        private readonly ITDirector _director;

        public Mediator(UXDesigner designer, ITDirector director) {
            _designer = designer;
            _director = director;
            _designer.SetMediator(this);
            _director.SetMediator(this);
        }

        public void Notify(Employee employee, string msg) {
            switch (employee) {
                case ITDirector _:
                    _designer.SetWork(msg != string.Empty);
                    break;
                case UXDesigner _:
                    if (msg == "<-Дизайнер в работе") {
                        _director.GiveCommand(string.Empty);
                    }

                    break;
            }
        }
    }
}