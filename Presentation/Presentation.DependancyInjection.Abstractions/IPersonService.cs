using Presentation.DependancyInjection.Application.Abstractions.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.DependancyInjection.Application.Abstractions
{
    public interface IPersonService
    {
        /// <summary>
        /// Get a new person
        /// </summary>
        /// <returns>If the person has been added</returns>
        PersonDTO GetPerson(int id);
    }
}
