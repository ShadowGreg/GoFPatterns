using System;

namespace GoFPatterns.Behavioral {
    public interface IVisitor {
        void visit(Zoo zoo);
        void visit(Cinema cinema);
        void visit(Circus сircus);
        void visit(Park park);
    }

    public interface IPlace {
        void Accept(IVisitor v);
    }

    public class Zoo: IPlace {
        public void Accept(IVisitor v) {
            v.visit(this);
        }
    }

    public class Cinema: IPlace {
        public void Accept(IVisitor v) {
            v.visit(this);
        }
    }

    public class Circus: IPlace {
        public void Accept(IVisitor v) {
            v.visit(this);
        }
    }

    public class Park: IPlace {
        public void Accept(IVisitor v) {
            v.visit(this);
        }
    }

    public class HolidayMaker: IVisitor {
        public string Msg = string.Empty;
        public void visit(Zoo zoo) {
            Msg =  "В зоопарке я увидел слона. ";
        }

        public void visit(Cinema cinema) {
            Msg = "В кинотеатре мы посомтрели фильм Армагедон. ";
        }

        public void visit(Circus сircus) {
            Msg =  "В цирке мы увидели акробата. ";
        }

        public void visit(Park park) {
            Msg =  "В парке мы увидели акробата. ";
        }
    }
}