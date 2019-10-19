using System;

namespace Presentation.Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 0;
            integer = null; //Compilation error

            int? nullableInteger = 0;
            nullableInteger = null; //No compilation error

            Nullable<int> nullable = 0;
            nullable = null; //No compilation error
        }
    }
}
