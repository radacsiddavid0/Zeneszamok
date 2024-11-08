using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zeneszamok.Service;

namespace Zeneszamok.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ZeneszamController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ZeneszamService.GetZeneszamok());
        }
    }
}
