using System;

namespace Walkin_Report
{
    public class Action
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int level { get; set; }
        public bool selected { get; set; } = false;
    }
}