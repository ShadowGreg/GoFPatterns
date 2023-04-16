namespace GoFPatterns.Structural.Adapter {
    public interface IScales {
        float GetWeight();
    }

    public class RussianScales: IScales {
        private readonly float _currentWeight;
        public RussianScales(float weight) => _currentWeight = weight;
        public float GetWeight() => _currentWeight;
    }
    public class BritishScales {
        private readonly float _currentWeight;
        public BritishScales(float weight) => _currentWeight = weight;
        public float GetWeight() => _currentWeight;
    }

    public class AdapterForBritishScales: IScales {
        private readonly BritishScales _britishScales;
        public AdapterForBritishScales( BritishScales scales) => _britishScales = scales;
        public float GetWeight() => _britishScales.GetWeight()*0.453f;
    }

    public class Class1 { }
}