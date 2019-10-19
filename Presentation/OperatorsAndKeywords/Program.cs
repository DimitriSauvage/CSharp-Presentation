using System;
using System.Collections.Generic;
using System.IO;

namespace Presentation.OperatorsAndKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operators
            //Operator ??
            string? myString = null;
            string mySecondString = myString ?? String.Empty;

            //Operator ??=
            List<int> numbers = null;
            (numbers ??= new List<int>()).Add(5);
            #endregion


            #region Keywords
            string name = nameof(DateTime); //Value = "DateTime"
            string value = nameof(name);    //Value = "name"

            Type stringType = typeof(string);   //Get the string type
            Type nameType = name.GetType();     //Get the string type

            int defaultInt = default(int);          //Value = 0
            string defaultString = default(string); //Value = null
            object defaultObject = default(object); //Value = null

            Console.ReadLine();
            #endregion


        }
    }
}
