using Prensentation.DependancyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.DependancyInjection.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        /// <summary>
        /// Add a new person
        /// </summary>
        /// <returns>If the person has been added</returns>
        public bool AddPerson()
        {
            return true;
        }
    }
}
