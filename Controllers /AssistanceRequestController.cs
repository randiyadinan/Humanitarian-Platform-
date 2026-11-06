using Microsoft.AspNetCore.Mvc;
using HumanitarianAPI.Models;
using System.Collections.Generic;

namespace HumanitarianAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistanceRequestController : ControllerBase
    {
        private static List<AssistanceRequest> requests = new List<AssistanceRequest>();

     
        [HttpGet]
        public ActionResult<IEnumerable<AssistanceRequest>> GetRequests()
        {
            return Ok(requests);
        }

     
        [HttpPost]
        public ActionResult<AssistanceRequest> CreateRequest([FromBody] AssistanceRequest newRequest)
        {
            newRequest.Id = requests.Count + 1;
            requests.Add(newRequest);
            return Ok(newRequest);
        }
    }
}
