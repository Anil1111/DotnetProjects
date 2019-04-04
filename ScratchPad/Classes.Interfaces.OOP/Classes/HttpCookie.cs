using System;
using System.Collections.Generic;

namespace Classes.Interfaces.OOP.Classes
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }


        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //indexer for dictionary
        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }
    }
}
