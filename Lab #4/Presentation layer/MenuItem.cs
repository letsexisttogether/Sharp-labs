using System;

namespace Presentation_layer
{
    public class MenuItem
    {
        protected string _title = string.Empty;
        protected Action _selected;

        public MenuItem(string title, Action selected)
        {
            _title = title;
            _selected = selected;
        }

        public void Execute()
        {
            _selected.Invoke();
        }

        public override string ToString()
        {
            return _title;
        }

    }
}
