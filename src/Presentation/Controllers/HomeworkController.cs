using Application.DataTransferObjects.HomeWorks;
using Application.Services.Contracts.Homeworks;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeworkController : ControllerBase
    {
        private readonly IHomeworkService _homeworkService;

        public HomeworkController(IHomeworkService homeworkService)
            => _homeworkService = homeworkService;

        [HttpPost]
        public async Task<IActionResult> PostHomeworkAsync(HomeworkCreationDTO homeworkCreationDTO)
        {
            var homework = await _homeworkService.AddAsync(homeworkCreationDTO);

            return Ok(homework);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeworkAsync()
        {
            var homeworks = await _homeworkService.GetAllAsync();

            return Ok(homework);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeworkAsync(long Id)
        {
            var homework = await _homeworkService.GetByIdAsync(Id);

            return Ok(homework);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHomeworkAsync(HomeworkModificationDTO homeworkModificationDTO, long Id)
        {
            var homework = await _homeworkService.UpdateAsync(homeworkModificationDTO, Id);

            return Ok(homework);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeworkAsync(long Id)
        {
            var homework = await _homeworkService.DeleteAsync(Id);

            return Ok(homework);
        }
    }
}
