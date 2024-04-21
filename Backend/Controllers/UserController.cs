using Backend.DataAccess.Interfaces;
using Backend.DataAccess.Models;
using Backend.DataAccess.Repositories;
using Backend.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private IUnitOfWork _unitOfWork;

        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork )
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _unitOfWork.UserRepository.GetUser("test2", "test2");
        }

        [HttpPost]
        public void Post(User user) 
        {
           _unitOfWork.UserRepository.AddUser(user);
           _unitOfWork.SaveChangesAsync();
        }
    }
}
