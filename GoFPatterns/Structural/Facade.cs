namespace GoFPatterns.Structural {
    
    public class OperationA {
        public string SomeActionA() => "Выполнена операция класса А";
    }
    
    public class OperationB {
        public string SomeActionB() => "Выполнена операция класса B";
    }
    
    public class OperationC {
        public string SomeActionC() => "Выполнена операция класса C";
    }

    public class Facade {
        private readonly OperationA _a;
        private readonly OperationB _b;
        private readonly OperationC _c;

        public Facade(OperationA a, OperationB b, OperationC c) {
            _a = a;
            _b = b;
            _c = c;
        }
        public string FirstDifficultyOperation() => _a.SomeActionA()+_b.SomeActionB();
        public string SecondDifficultyOperation() => _a.SomeActionA() + _b.SomeActionB() + _c.SomeActionC();
    }
}