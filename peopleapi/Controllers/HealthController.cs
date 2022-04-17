using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace peopleapi.Controllers
{
    [Route("healthz")]
    public class HealthController : Controller
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// GET the health status of this mainly for the k8s health check
        /// but can be used for any kind of health check.
        /// </summary>
        /// <returns>an OK if good to go, otherwise returns a bad request</returns>
        /// <response code="200">Returns OK if this works</response>
        /// <response code="400">If the health checks is bad</response>
        [HttpGet]
        public ActionResult<string> Get()
        {
            try
            {
                return Ok("ok");
            }
            catch(Exception ex)
            {
                return BadRequest("Improper API config");
            }
        }
    }
}