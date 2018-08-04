using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var count = 0;
            return $"You are visitor no. {count}";
        }
    }
}
