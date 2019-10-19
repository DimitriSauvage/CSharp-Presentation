using System;

namespace Prensetaion.Escaping
{
    class Program
    {
        static void Main(string[] args)
        {
            //THIS IS BORING !
            String without = "C:\\Users\\dimit\\Documents\\Visual Studio 2019\\Templates";

            //THIS IS AWESOME !
            string with = @"C:\Users\dimit\Documents\Visual Studio 2019\Templates";

            Console.WriteLine(without);
            Console.WriteLine(with); ;
        }
    }
}
