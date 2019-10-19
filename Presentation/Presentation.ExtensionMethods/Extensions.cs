using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.ExtensionMethods
{
    public static class Extensions
    {
        /// <summary>
        /// Get the element at the specified index
        /// </summary>
        /// <typeparam name="T">Type of the elements</typeparam>
        /// <param name="elements">Elements</param>
        /// <param name="index">Index to get</param>
        /// <returns>Element</returns>
        public static T Get<T>(this IEnumerable<T> elements, int index) where T : class
        {
            T result = null;
            //Browse elements to get the element a the specified index
            IEnumerator<T> enumerator = elements.GetEnumerator();
            int currentIndex = 0;
            bool found = false;

            while (!found && enumerator.MoveNext())
            {
                if (index.Equals(currentIndex))
                {
                    result = enumerator.Current;
                    found = true;
                }
                else
                {
                    index++;
                }
            }
            return result;
        }
    }
}
