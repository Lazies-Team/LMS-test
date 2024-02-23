using Application.DataTransferObjects.HomeWorks;
using Application.Services.Contracts.Homeworks;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeworkFileController : ControllerBase
    {
        private readonly IHomeworkFileService _homeworkFileService;

        public HomeworkFileController(IHomeworkFileService homeworkFileService)
            => _homeworkFileService = homeworkFileService;

        [HttpPost]
        public async Task<IActionResult> PostHomeworkFileAsync([FromForm] HomeworkFileCreationDTO homeworkFileCreationDTO)
        {
            var homeworkFile = await _homeworkFileService.AddAsync(homeworkFileCreationDTO);

            return Ok(homeworkFile);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeworkFileAsync()
        {
            var homeworkFiles = await _homeworkFileService.GetAllAsync();

            return Ok(homeworkFiles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeworkFileAsync(long id)
        {
            var homeworkFile = await _homeworkFileService.GetByIdAsync(id);

            return Ok(homeworkFile);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHomeworkFileAsync(HomeworkFileModificationDTO homeworkFileModificationDTO, long id)
        {
            var homeworkFile = await _homeworkFileService.UpdateAsync(homeworkFileModificationDTO, id);

            return Ok(homeworkFile);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeworkFileAsync(long id)
        {
            var homeworkFile = await _homeworkFileService.DeleteAsync(id);

            return Ok(homeworkFile);
        }
    }
}
