using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using peopleapi.Models;

namespace peopleapi.Controllers
{
    [Route("/")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        /// <summary>
        /// GET the list o people
        /// </summary>
        /// <returns>
        /// HTTP Status showing it was found or that there is an error. And the list of people records.
        /// </returns>
        /// <response code="200">Returns the list of People records</response>
        [HttpGet]
        public ActionResult<IEnumerable<People>> Get()
        {
            List<People> peopleList = new List<People>();
            peopleList.Add(new People() { firstName = "Mario", lastName = "Tsukiyama", title = "Mr.", middleName = "Toshio" });
            peopleList.Add(new People() { firstName = "Dalva", lastName = "Moreira", title = "Ms.", middleName = "Cordeiro" });
            peopleList.Add(new People() { firstName = "Karina", lastName = "Cunha", title = "Ms.", middleName = "Soares" });

            return Ok(peopleList);
        }

        /// <summary>
        /// GET a people record
        /// </summary>
        /// <param name="id">
        /// The id of People.
        /// </param>
        /// <returns>
        /// HTTP Status showing it was found or that there is an error.
        /// And the the person matching this ID, which we are faking for now.
        /// </returns>
        /// <response code="200">Returns the People record</response>
        // [HttpGet("{id}")]
        // public ActionResult<People> Get(string id)
        // {
        //     People p = new People();
        //     p.firstName = "Mario"
        // }
    }
}