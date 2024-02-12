using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
            => _userService = userService;

        [HttpPost]
        public async Task<IActionResult> PostUserAsync(UserCreationDTO userCreationDTO)
        {
            var user = await _userService.AddAsync(userCreationDTO);

            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByIdAsync(long id)
        {
            var user = await _userService.GetByIdAsync(id);

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _userService.GetAllAsync();

            return Ok(users);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserAsync([FromForm] UserModificationDTO userModificationDTO, long id)
        {
            var user = await _userService.UpdateAsync(userModificationDTO, id);

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAsync(long id)
        {
            var user = await _userService.DeleteAsync(id);

            return Ok(user);
        }
    }
}
