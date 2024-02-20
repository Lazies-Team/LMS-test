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
        {
            _homeworkFileService = homeworkFileService;
        }

        [HttpPost]
        public async Task<IActionResult> PostHomeworkFileAsync([FromForm]HomeworkFileCreationDTO homeworkFileCreationDTO)
        {
            var created = await _homeworkFileService.AddAsync(homeworkFileCreationDTO);

            return Ok(created);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomeworkFileAsync()
        {
            var getallhomeworkfile = await _homeworkFileService.GetAllAsync();

            return Ok(getallhomeworkfile);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeworkFileAsync(long id)
        {
            var getbyidHomeworkfile = await _homeworkFileService.GetByIdAsync(id);

            return Ok(getbyidHomeworkfile);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHomeworkFileAsync(HomeworkFileModificationDTO homeworkFileModificationDTO, long id)
        {
            var updatehomeworkfile = await _homeworkFileService.UpdateAsync(homeworkFileModificationDTO, id);

            return Ok(updatehomeworkfile);
        }

        [HttpDelete("{id}")] 
        public async Task<IActionResult> DeleteHomeworkFileAsync(long id)
        {
            var deleted  = await _homeworkFileService.DeleteAsync(id);

            return Ok(deleted);
        }
    }
}
