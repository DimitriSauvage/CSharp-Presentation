using System;
using System.Text;

namespace Presentation.Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jean";
            string lastName = "DUPOND";
            string civility = "M.";

            //Concatenation
            string concatenation = "Bonjour " + civility + " " + lastName + " " + firstName;

            //StringBuilder
            StringBuilder stringBuilder =
                new StringBuilder("Bonjour ").Append(civility).Append(" ").Append(lastName).Append(" ").Append(firstName);

            //Format method
            string stringFormat = string.Format("Bonjour {0} {1} {2}", civility, lastName, firstName);

            //Interpolation
            string interpolation = $"Bonjour {civility} {lastName} {firstName}";

            Console.WriteLine(concatenation);
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine(stringFormat);
            Console.WriteLine(interpolation);

            Console.ReadKey();
        }
    }
}
