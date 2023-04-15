using System;

namespace GoFPatterns.Creational.Prototype {
    public class Sheep: IAnimal {
        private string name;
        private Random rnd = new Random();
        private int maxRND = 10_000_000;
        private readonly int hashCode;

        public Sheep() {
            hashCode = rnd.Next(maxRND);
        }

        private Sheep(Sheep donor) {
            name = donor.GetName();
            hashCode = rnd.Next(maxRND);
        }

        public void SetName(string name) => this.name = name;

        public string GetName() => name;

        public IAnimal Clone() => new Sheep(this);

        public override bool Equals(object inObj) {
            return inObj.GetHashCode() == this.hashCode;
        }
        public override int GetHashCode() => hashCode;
    }
}