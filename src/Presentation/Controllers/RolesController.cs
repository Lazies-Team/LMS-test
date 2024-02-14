using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Application.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
            => _roleService = roleService;

        [HttpPost]
        public async Task<IActionResult> PostRoleAsync(RoleCreateionDTO roleCreateionDTO)
        {
            var role = await _roleService.AddAsync(roleCreateionDTO);

            return Ok(role);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRolesAsync()
        {
            var roles = await _roleService.GetAllAsync();

            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleByIdAsync(long id)
        {
            var role = await _roleService.GetByIdAsync(id);

            return Ok(role);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoleAsync(RoleModificationDTO roleModificationDTO, long id)
        {
            var role = await _roleService.UpdateAsync(roleModificationDTO, id);

            return Ok(role);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleAsync(long id)
        {
            var role = await _roleService.DeleteAsync(id);

            return Ok(role);
        }
    }
}
