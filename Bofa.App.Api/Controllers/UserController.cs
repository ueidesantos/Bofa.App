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
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "GetAllUsers")]
        public async Task<ActionResult<IAsyncEnumerable<User>>> GetUsers()
        {
            var result = await _userService.GetAll();
            return Ok(result);
        }

        [HttpPost(Name = "AddUser")]
        public async Task<ActionResult<IAsyncEnumerable<User>>> AddUser(User user)
        {
            await _userService.AddUser(user);

            return Created();
        }
    }
}
