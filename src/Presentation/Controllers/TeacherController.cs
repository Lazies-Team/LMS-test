using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
            => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAllTeacherAsync()
        {
            var teachers = await _service.GetAllAsync();

            return Ok(teachers);
        }
        [HttpGet]
        public async Task<IActionResult> GetByIdTeacherAsync(long id)
        {
            var teacher = await _service.GetByIdAsync(id);

            return Ok(teacher);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTeacherAsync(TeacherModificationDTO teacherModificationDTO, long id)
        {
            var teacher = await _service.UpdateAsync(teacherModificationDTO, id);

            return Ok(teacher);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTeacherAsync(long id)
        {
            var teacher = await _service.DeleteAsync(id);

            return Ok(teacher);
        }
    }
}
