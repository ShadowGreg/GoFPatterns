namespace GoFPatterns.Structural {
    public interface IControlImpl {
        string DrawControl();
    }

    public abstract class ImplControl {
        protected IControlImpl _implementation;
        protected ImplControl(IControlImpl impl) => _implementation = impl;
        public abstract string Draw();
    }

    public class WindowsControl: IControlImpl {
        public string DrawControl() => "нарисован для Windows";
    }

    public class WebControl: IControlImpl {
        public string DrawControl() => "нарисован для Web приложения";
    }

    public class Button: ImplControl {
        public Button(IControlImpl imp): base(imp) { }

        public override string Draw() =>
            "Элменет кнопка " + _implementation.DrawControl();
    }

    public class TextBox: ImplControl {
        public TextBox(IControlImpl imp): base(imp) { }

        public override string Draw() =>
            "Элменет текст бокс " + _implementation.DrawControl();
    }

    public class Bridge { }
}