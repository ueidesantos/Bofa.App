using Bofa.App.Domain.Core;
using Bofa.App.Repository;

namespace Bofa.App.Application.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            try
            {
                return _userRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void AddUser(User user)
        {
            var validator = new UserValidator();
            var resultValidation = validator.Validate(user);
            if (!resultValidation.IsValid)
                throw new Exception("Dados Inválidos");

            _userRepository.AddUser(user);
        }

    }
}
