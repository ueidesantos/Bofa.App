using Bofa.App.Domain.Core;

namespace Bofa.App.Repository
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users;
        public UserRepository()
        {
            if (_users is null)
            {
                var users = new List<User>
                {
                    new User() { Id = 1, Name = "Joao", Age = 30 },
                    new User() { Id = 2, Name = "Maria", Age = 25 },
                    new User() { Id = 3, Name = "Jose", Age = 40 }
                };
                _users = users;
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void AddUser(User user) => _users.Add(user);
        
    }
}
