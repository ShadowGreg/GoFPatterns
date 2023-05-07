namespace GoFPatterns.Behavioral {
    public abstract class State {
        protected TrafficLight _trafficLight;

        public TrafficLight TrafficLight
        {
            set => _trafficLight = value;
        }

        public abstract string NextState();
        public abstract string PreviousState();
    }

    public class TrafficLight {
        private State _state;
        public TrafficLight(State state) => SetState(state);

        public string SetState(State state) {
            _state = state;
            _state.TrafficLight = this;
            return "Установлено состояние " + _state;
        }

        public string NextState() {
            return "Установлено состояние " + _state.NextState();
        }
        public string PreviousState() {
            return "Установлено состояние " + _state.PreviousState();
        }
    }

    public class GreenState : State{
        public override string NextState() {
            _trafficLight.SetState(new YellowState());
            return "Состояние переведено из зелёного в жёлтый ";
        }

        public override string PreviousState() {
            return "Состяние преведено в зелёный ";
        }
    }
    
    public class YellowState : State{
        public override string NextState() {
            _trafficLight.SetState(new ReadState());
            return "Состояние переведено из жёлтого в красный ";
        }

        public override string PreviousState() {
            _trafficLight.SetState(new GreenState());
            return "Состяние преведено из жёлтого в зелёный ";
        }
    }
    
    public class ReadState : State{
        public override string NextState() {
            return "Состояние красный ";
        }

        public override string PreviousState() {
            _trafficLight.SetState(new YellowState());
            return "Состяние преведено в жёлтый ";
        }
    }
}