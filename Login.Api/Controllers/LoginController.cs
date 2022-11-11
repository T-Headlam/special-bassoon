using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Api.Model;
using Login.Api.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Login.Api.Controllers
{
    [Route("api/v1/login/[action]")]
    public class LoginController : ControllerBase
    {
        // GET: api/values    
        [HttpGet]
        public async Task<ActionResult<HealthCheckReponse>> HealthCheck()
        {
            var response = new HealthCheckReponse();

            response.Status = "Good";

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<HealthCheckReponse>> CreateUser()
        {
            var response = new HealthCheckReponse();

            response.Status = "Good";

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<HealthCheckReponse>> Login()
        {
            var response = new HealthCheckReponse();

            response.Status = "Good";

            return Ok(response);
        }
    }
}

