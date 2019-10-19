using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Presentation.ExtensionMethods;

namespace Presentation.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Test> tests = new List<Test>()
            {
                new Test(1), new Test(2)
            };

            //SIMILAR
            Test test = Extensions.Get(tests, 1);
            tests.Get(1);
        }
    }

    class Test
    {
        public int Value { get; set; }

        public Test(int val)
        {
            this.Value = val;
        }
    }
}
