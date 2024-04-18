using Backend.Models;
using Backend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ILogger<SessionController> _logger;
        private TaskUpContext _taskUpContext;

        public SessionController(ILogger<SessionController> logger, TaskUpContext taskUpContext )
        {
            _logger = logger;
            _taskUpContext = taskUpContext;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
           return _taskUpContext.Users.ToList();
        }

        [HttpPost]
        public void Post(User user) 
        {
            Console.WriteLine(user);
            _taskUpContext.Users.Add(user);
            _taskUpContext.SaveChanges();
        }
    }
}
