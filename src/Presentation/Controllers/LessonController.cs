using Application.DataTransferObjects.Lessons;
using Application.Services.Contracts.Lessons;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
            => _lessonService = lessonService;

        [HttpPost]
        public async Task<IActionResult> PostLessonAsync(LessonCreationDTO lessonCreationDTO)
        {
            var result = await _lessonService.AddAsync(lessonCreationDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLessonAsync()
        {
            var result = await _lessonService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIdLessonAsync(long Id)
        {
            var result = await _lessonService.GetByIdAsync(Id);

            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateLessonAsync(LessonModificationDTO lessonModificationDTO, long Id)
        {
            var result = await _lessonService.UpdateAsync(lessonModificationDTO, Id);

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteLessonAsync(long Id)
        {
            var result = await _lessonService.DeleteAsync(Id);

            return Ok(result);
        }
    }
}
