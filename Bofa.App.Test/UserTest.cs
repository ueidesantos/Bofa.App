using Bofa.App.Application.Services;
using Bofa.App.Test.Mock;

namespace Bofa.App.Test
{
    public class UserTest
    {
        [Fact]
        public void CreateUser_WithValidUser_SholdBeSuccess()
        {
            //Arrange
            var validUser = UserMock.CreateValidUserMock();
            var userRepository = UserMock.CreateValidUserMock();
            var userService = new UserService(UserMock.GetUserRepositoryMock());

            //Act
            try
            {
                userService.AddUser(validUser);

            }
            catch (Exception)
            {

                Assert.Fail();
            }


            //Assert
            Assert.True(true);

        }

        [Fact]
        public void CreateUser_WithInValidUser_SholdFail()
        {
            //Arrange
            var validUser = UserMock.CreateInValidUserMock();
            var userRepository = UserMock.CreateValidUserMock();
            var userService = new UserService(UserMock.GetUserRepositoryMock());

            //Act
            try
            {
                userService.AddUser(validUser);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }
    }
}