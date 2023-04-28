using System.Collections.Generic;
using System.Linq;

namespace GoFPatterns.Structural {
    public abstract class ComposerItem {
        protected readonly string ItemName;
        protected string OwnerName;
        protected ComposerItem(string name) => ItemName = name;
        public void SetOwnerName(string name) => OwnerName = name;
        public virtual string Display() => ItemName;
        public abstract void Add(ComposerItem item);
        public abstract void Remove(ComposerItem item);
        
    }


    public class ClickableComposerItem: ComposerItem {
        public ClickableComposerItem(string name): base(name) { }
        public override void Add(ComposerItem item) {
            throw new System.NotImplementedException();
        }

        public override void Remove(ComposerItem item) {
            throw new System.NotImplementedException();
        }
    }

    public class DropDownComposerItem: ComposerItem {
        private readonly List<ComposerItem> _childrenItems;

        public DropDownComposerItem(string name): base(name) {
            _childrenItems = new List<ComposerItem>();
        }

        public override void Add(ComposerItem subItem) {
            subItem.SetOwnerName(ItemName);
            _childrenItems.Add(subItem);
        }

        public override void Remove(ComposerItem item) => _childrenItems.Remove(item);

        public override string Display() {
            return _childrenItems.Where(item => OwnerName != null).Aggregate(
                "",
                (current, item) => current + (OwnerName + ItemName + item.Display())
            );
        }
    }


    public class Composite { }
}