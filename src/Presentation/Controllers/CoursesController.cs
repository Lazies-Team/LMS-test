using Application.DataTransferObjects.Courses;
using Application.Services.Contracts.Courses;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
            => _courseService = courseService;

        [HttpPost]
        public async Task<IActionResult> PostCourseAsync(CourseCreationDTO courseCreationDTO)
        {
            var course = await _courseService.AddAsync(courseCreationDTO);

            return Ok(course);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCoursesAsync()
        {
            var courses = await _courseService.GetAllAsync();

            return Ok(courses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseByIdAsync(long id)
        {
            var course = await _courseService.GetByIdAsync(id);

            return Ok(course);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseAsync(CourseModificationDTO courseModificationDTO, long id)
        {
            var course = await _courseService.UpdateAsync(courseModificationDTO, id);

            return Ok(course);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseAsync(long id)
        {
            var course = await _courseService.DeleteAsync(id);

            return Ok(course);
        }
    }
}
