using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace random_game_server.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ILogger<MainController> logger;

        public MainController(ILogger<MainController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        [Route("/")]
        [Route("/index")]
        public string Index()
        {
            logger.LogInformation("Service is up and running");
            return "Service is up and running";
        }

        [HttpPost]
        [Route("/login")]
        public bool Login(string login, string password)
        {
            logger.LogInformation("login: " + login + ", password: " + password);
            if (login == "admin" && password == "12345")
                return true;
            else
                return false;
        }
    }
}
