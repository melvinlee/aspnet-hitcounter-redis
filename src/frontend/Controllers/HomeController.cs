using System;
using Microsoft.AspNetCore.Mvc;
using ServiceStack.Redis;

namespace frontend.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IRedisClient _redisClient;

        public HomeController(IRedisClient redisClient)
        {
            _redisClient = redisClient;
        }

        // GET /
        [HttpGet]
        public ActionResult<string> Get()
        {
            var count = _redisClient.IncrementValue("hits");
            return $"You are visitor no. {count} \n(host: {Environment.MachineName})";
        }
    }
}