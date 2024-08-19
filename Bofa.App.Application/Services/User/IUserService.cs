using Bofa.App.Domain.Core;

namespace Bofa.App.Application.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();

        void AddUser(User user);
    }
}
