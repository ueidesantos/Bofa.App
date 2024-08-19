using Bofa.App.Domain.Core;
using Bofa.App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bofa.App.Test.Mock
{
    public static class UserMock
    {
        public static User CreateValidUserMock() 
        =>new User() { Id = 1, Name = "UserTest", Age = 20};

        public static User CreateInValidUserMock()
        => new User() { Id = 1, Name = string.Empty, Age = 0 };

        public static UserRepository GetUserRepositoryMock() => new UserRepository();
    }
}
