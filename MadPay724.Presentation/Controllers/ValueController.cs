using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MadPay724.Presentation.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {

            return "hamid";
        }
    }
}
