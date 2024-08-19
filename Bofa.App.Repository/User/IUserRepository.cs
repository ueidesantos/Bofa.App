using Bofa.App.Domain.Core;

namespace Bofa.App.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
