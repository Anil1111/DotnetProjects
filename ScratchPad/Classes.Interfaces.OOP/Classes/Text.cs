using System;

namespace Classes.Interfaces.OOP.Classes
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("Added line to " + url);
        }
    }
}