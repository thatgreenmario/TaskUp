namespace Backend.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        Task SaveChangesAsync();
    }
}
