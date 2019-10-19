using Prensentation.DependancyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.DependancyInjection.Implementations
{
    public class PersonService : IPersonService
    {
        #region Fields
        /// <summary>
        /// Persons manager
        /// </summary>
        private readonly IPersonRepository personRepository;
        /// <summary>
        /// Other declaration possiblity
        /// </summary>
        public IPersonRepository PersonRepository { get; }
        #endregion

        #region Constructor
        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
            this.PersonRepository = personRepository;
        }


        #endregion

        #region Methods
        /// <summary>
        /// Add a new person
        /// </summary>
        /// <returns>If the person has been added</returns>
        public bool AddPerson()
        {
            return this.PersonRepository.AddPerson();
        }
        #endregion

    }
}
