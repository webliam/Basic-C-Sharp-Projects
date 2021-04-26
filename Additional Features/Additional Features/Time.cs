using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Time
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Time(string name, int year)
        {
            Name = name;
            Year = year;
        }
        public Time() : this("Two years ago", 2016)
        {
        }
    }
}
