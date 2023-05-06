using System.Collections.Generic;

namespace GoFPatterns.Behavioral {
    public interface IMemento {
        double GetGold();
        double GetSilver();
    }

    public class ExchangeMemento: IMemento {
        private double _gold;
        private double _silver;

        public ExchangeMemento(double gold, double silver) {
            _gold = gold;
            _silver = silver;
        }

        public double GetGold() => _gold;
        public double GetSilver() => _silver;
    }

    public class Exchange {
        private double _gold;
        private double _silver;

        public Exchange(double gold, double silver) {
            _gold = gold;
            _silver = silver;
        }

        public string GetGold() => "Количество золота: " + _gold;
        public string GetSilver() => "Количество серебра: " + _silver;

        public void Sell() {
            if (_gold > 0) _gold--;
        }

        public void Buy() => _silver++;

        public ExchangeMemento Save() => new ExchangeMemento(_gold, _silver);

        public void Restore(IMemento exchangeMemento) {
            _gold = exchangeMemento.GetGold();
            _silver = exchangeMemento.GetSilver();
        }
    }

    public class Memory {
        private Stack<IMemento> _history;
        private Exchange _exchange;

        public Memory(Exchange exchange) {
            _exchange = exchange;
            _history = new Stack<IMemento>();
        }

        public void Backup() => _history.Push(_exchange.Save());

        public void Undo() {
            if (_history.Count == 0) return;
            _exchange.Restore(_history.Pop());
        }
    }

    public class Memento { }
}