using Microsoft.AspNetCore.Mvc;
using Presentation.DependancyInjection.Application.Abstractions;
using System;

namespace Presentation.DependancyInjection.Presentation
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        #region Fields
        /// <summary>
        /// Application manager for persons
        /// </summary>
        public IPersonService PersonService { get; set; }
        #endregion

        #region Constructor
        public PersonController(IPersonService personService)
        {
            this.PersonService = personService;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Just for the test
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetPerson([FromRoute] int id)
        {
            
            return Ok(this.PersonService.GetPerson(id));
        }
        #endregion
    }
}
