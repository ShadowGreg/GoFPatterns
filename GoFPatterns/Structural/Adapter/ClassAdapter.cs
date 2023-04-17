namespace GoFPatterns.Structural {
    public interface ICScales {
        float GetWeight();
        string Adjust();
    }

    public class CRussianScales: ICScales {
        private readonly float currentWeight;
        public CRussianScales(float currentWeight) => this.currentWeight = currentWeight;
        public float GetWeight() => this.currentWeight;
        public string Adjust() => "регулировка русских весов";
    }

    public class BritanScales {
        private readonly float currentWeight;
        public BritanScales(float currentWeight) => this.currentWeight = currentWeight;
        public float GetWeight() => this.currentWeight;
        public string Adjust() => "регулировка британских весов";
    }

    public class AdapterForBritanScales: BritanScales, ICScales{
        public AdapterForBritanScales(float cw): base(cw) { }

        float ICScales.GetWeight() => base.GetWeight() * 0.453f;
        
        string ICScales.Adjust() => base.Adjust()+"\n британские весы адаптированны под российский вес";
        
    }

    public class ClassAdapter { }
}