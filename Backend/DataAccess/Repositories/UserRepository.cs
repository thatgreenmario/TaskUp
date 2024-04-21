using Backend.DataAccess.Interfaces;
using Backend.DataAccess.Models;
using Backend.Repository;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly TaskUpContext _taskUpContext;

        public UserRepository(TaskUpContext taskUpContext)
        {
            _taskUpContext = taskUpContext;
        }
        public void AddUser(User user)
        {
            _taskUpContext.Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _taskUpContext.Users.Remove(user);
        }

        public IEnumerable<User> GetUser(string email, string passwordHash)
        {
           return _taskUpContext.Users.Where(User => User.Email == email && User.Password == passwordHash);
        }

        public void UpdateUser(User user)
        {
           _taskUpContext.Users.Update(user);
        }
    }
}
