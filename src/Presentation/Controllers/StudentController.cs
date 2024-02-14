using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
            => _studentService = studentService;

        [HttpGet]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await _studentService.GetAllAsync();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentByIdAsync(long id)
        {
            var student = await _studentService.GetByIdAsync(id);

            return Ok(student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudentAsync(long id, StudentModificationDTO studentModificationDTO)
        {
            var student = await _studentService.UpdateAsync(studentModificationDTO, id);

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentAsync(long id)
        {
            var student = await _studentService.DeleteAsync(id);

            return Ok(student);
        }
    }
}
