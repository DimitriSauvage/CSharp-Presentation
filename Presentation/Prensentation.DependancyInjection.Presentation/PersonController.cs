using Microsoft.AspNetCore.Mvc;
using Prensentation.DependancyInjection;
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
        [HttpGet]
        public IActionResult GetPerson()
        {
            
            return Ok(this.PersonService.AddPerson());
        }
        #endregion
    }
}
