using Backend.DataAccess.Interfaces;
using Backend.Repository;

namespace Backend.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaskUpContext _taskUpContext;
        public IUserRepository UserRepository { get; private set; }

        public UnitOfWork(TaskUpContext taskUpContext)
        {
            _taskUpContext = taskUpContext;
            UserRepository = new UserRepository(_taskUpContext);
        }
        public Task SaveChangesAsync()
        {
            return _taskUpContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _taskUpContext.Dispose();
        }
    }
}