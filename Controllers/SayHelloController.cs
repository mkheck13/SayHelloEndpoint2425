using Microsoft.AspNetCore.Mvc;

namespace SayHelloEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route("Greeting/{name}")]
        public string sayHello(string name)
        {
            return $"Hello, {name}.";
        }
    }
}