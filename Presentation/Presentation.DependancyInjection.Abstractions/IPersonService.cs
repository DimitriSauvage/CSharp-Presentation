﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prensentation.DependancyInjection
{
    public interface IPersonService
    {

        /// <summary>
        /// Add a new person
        /// </summary>
        /// <returns>If the person has been added</returns>
        bool AddPerson();
    }
}