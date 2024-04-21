using Backend.DataAccess.Models;

namespace Backend.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
        IEnumerable<User> GetUser(string username, string passwordHash);
    }
}
