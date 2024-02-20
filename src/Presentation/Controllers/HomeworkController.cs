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
        {
            _homeworkService = homeworkService;
        }

        [HttpPost]
        public async Task<IActionResult> PostHomeworkAsync(HomeworkCreationDTO homeworkCreationDTO)
        {
            var created = await _homeworkService.AddAsync(homeworkCreationDTO);

            return Ok(created);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeworkAsync()
        {
            var getallhomework = await _homeworkService.GetAllAsync();

            return Ok(getallhomework);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeworkAsync(long Id)
        {
            var getByIdHomework = await _homeworkService.GetByIdAsync(Id);

            return Ok(getByIdHomework);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHomeworkAsync(HomeworkModificationDTO homeworkModificationDTO, long Id)
        {
            var updatedhomework = await _homeworkService.UpdateAsync(homeworkModificationDTO, Id);

            return Ok(updatedhomework);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeworkAsync(long Id)
        {
            var deletedHomework = await _homeworkService.DeleteAsync(Id);

            return Ok(deletedHomework);
        }
    }
}
