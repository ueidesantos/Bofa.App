using Bofa.App.Application.Services;
using Bofa.App.Domain.Core;
using Microsoft.AspNetCore.Mvc;

namespace Bofa.App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IServiceProvider serviceProvider)
        {
            _userService = serviceProvider.GetService<IUserService>();
        }

        [HttpGet(Name = "GetAllUsers")]
        public ActionResult<IAsyncEnumerable<User>> GetUsers()
        {
            var result = _userService.GetAll();

            return Ok(result);


        }

        [HttpPost(Name = "AddUser")]
        public ActionResult<IAsyncEnumerable<User>> AddUser(User user)
        {
            _userService.AddUser(user);

            return Created();


        }
    }
}
