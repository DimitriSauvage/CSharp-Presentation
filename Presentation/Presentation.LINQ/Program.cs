using System;
using System.Linq;

namespace Presentation.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Values
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            
            //New method
            var newMethod = numbers.Where(x => x % 2 == 0);

            //Old method
            var oldMethod =
                from num in numbers
                where (num % 2) == 0
                select num;


            //Here, the requests is not executed
            //Execution
            foreach (var num in oldMethod)
            {
                Console.WriteLine(num);
            }
            foreach (var num in newMethod)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();

        }
    }
}
