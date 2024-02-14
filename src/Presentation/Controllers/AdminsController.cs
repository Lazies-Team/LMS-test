using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminsController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAdminsAsync()
        {
            var admins = await _adminService.GetAllAsync();

            return Ok(admins);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdminByIdAsync(long id)
        {
            var admin = await _adminService.GetByIdAsync(id);

            return Ok(admin);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAdminAsync(AdminModificationDTO adminModificationDTO, long id)
        {
            var admin = await _adminService.UpdateAsync(adminModificationDTO, id);

            return Ok(admin);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAdminAsync(long id)
        {
            var admin = await _adminService.DeleteAsync(id);

            return Ok(admin);
        }
    }
}
