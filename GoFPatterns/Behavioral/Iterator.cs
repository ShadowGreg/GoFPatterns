using System.Dynamic;

namespace GoFPatterns.Behavioral {
    public class DataStack {
        private readonly int[] _items = new int[10];
        private int _lenght;
        public DataStack() => _lenght = -1;

        public DataStack(DataStack inDataStack) {
            _items = inDataStack._items;
            _lenght = inDataStack._lenght;
        }

        public int[] Items => _items;
        public int Lenght => _lenght;

        public void Push(int value) => _items[++_lenght] = value;
        public int Pop() => _items[_lenght--];

        public static bool operator ==(DataStack firstItem, DataStack secondItem) {
            StackIterator it1 = new StackIterator(firstItem),
                it2 = new StackIterator(secondItem);
            while (it1.IsEnd() || it2.IsEnd()) {
                if (it1.Get() != it2.Get()) break;
                it1++;
                it2++;
            }
            return !it1.IsEnd() && !it2.IsEnd();
        }

        public static bool operator !=(DataStack firstItem, DataStack secondItem) {
            StackIterator it1 = new StackIterator(firstItem),
                it2 = new StackIterator(secondItem);
            while (it1.IsEnd() || it2.IsEnd()) {
                if (it1.Get() != it2.Get()) break;
                it1++;
                it2++;
            }

            return !(!it1.IsEnd() && !it2.IsEnd());
        }

        public class StackIterator {
            private DataStack _stack;
            private int _index;

            public StackIterator(DataStack myStack) {
                _stack = myStack;
                _index = 0;
            }

            public static StackIterator operator ++(StackIterator s) {
                s._index++;
                return s;
            }

            public int Get() {
                return _index < _stack.Lenght ? _stack.Items[_index] : 0;
            }

            public bool IsEnd() => _index != _stack.Lenght + 1;
        }
    }

    public class Iterator { }
}