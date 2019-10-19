using System;
using System.Collections.Generic;
using System.IO;

namespace Presentation.InitializationAtDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            //With list
            IEnumerable<DateTime> dateTimes = new List<DateTime>()
            {
                new DateTime(2019, 10, 2019),
                DateTime.Now,
                DateTime.MinValue,
                DateTime.MaxValue
            };

            foreach (var dateTime in dateTimes)
            {
                Console.WriteLine($"{dateTime.ToShortDateString()} - {dateTime.ToShortTimeString()}");
            }

            //With class
            Test test = new Test()
            {
                MyString = String.Empty
            };
            

        }
    }

    class Test
    {
        public string MyString { get; set; }
        public int MyInt { get; set; }
    }
}
