using AutoMapper;
using Presentation.DependancyInjection.Application.Abstractions;
using Presentation.DependancyInjection.Application.Abstractions.DTO;
using Presentation.DependancyInjection.Model;
using Presentation.DependancyInjection.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.DependancyInjection.Implementations
{
    public class PersonService : IPersonService
    {
        #region Fields
        /*/// <summary>
        /// Persons manager
        /// </summary>
        private readonly IPersonRepository personRepository;*/
        /// <summary>
        /// Other declaration possiblity
        /// </summary>
        public IPersonRepository PersonRepository { get; }
        /// <summary>
        /// Mapper of the application
        /// </summary>
        public IMapper Mapper { get; }
        #endregion

        #region Constructor
        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            /*this.personRepository = personRepository;*/
            this.PersonRepository = personRepository;
            this.Mapper = mapper;
        }


        #endregion

        #region Methods
        /// <summary>
        /// Get a new person
        /// </summary>
        /// <returns>If the person has been added</returns>
        public PersonDTO GetPerson(int id)
        {
            Person person = this.PersonRepository.GetPerson(id);
            return this.Mapper.Map<PersonDTO>(person);
        }
        #endregion

    }
}
