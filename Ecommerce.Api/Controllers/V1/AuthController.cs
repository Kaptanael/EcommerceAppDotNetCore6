using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            return Ok("Hello");
        }
    }
}
