using System;

namespace GenBasic.Classes
{
    public class DelegatesAndEvents
    {
        public delegate void Display<T>(T sender, EventArgs e);
    }

    public class Shape
    {
        public event DelegatesAndEvents.Display<Shape> Displayed;

        private void OnDisplay()
        {
            Displayed?.Invoke(this, new EventArgs());
        }

        public void Display()
        {
            OnDisplay();
        }
    }
}
