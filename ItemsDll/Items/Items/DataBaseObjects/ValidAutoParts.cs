using System;
using System.Collections.Generic;
using System.IO;

namespace Items.DataBaseObjects
{
    public class ValidAutoParts
    {
        private Dictionary<string, List<string>> _parts = new Dictionary<string, List<string>>();
        private static ValidAutoParts _instance;

        private ValidAutoParts()
        {
            string[] lines = File.ReadAllLines("ValidAutoParts.txt");
            foreach (string line in lines)
            {
                string[] elements = line.Split(':');
                string brand = elements[0];
                string[] models = elements[1].Split(',');
                _parts.Add(brand, new List<string>(models));
            }
        }

        public static ValidAutoParts GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ValidAutoParts();
            }
            return _instance;
        }

        public Dictionary<string, List<string>> Parts
        {
            get { return _parts; }
        }
    }
}