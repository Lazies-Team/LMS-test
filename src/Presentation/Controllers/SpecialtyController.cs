using Application.DataTransferObjects.Courses;
using Application.Services.Contracts.Courses;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        private readonly ISpecialtyService _specialtyService;

        public SpecialtyController(ISpecialtyService specialtyService)
            => _specialtyService = specialtyService;

        [HttpPost]
        public async Task<IActionResult> PostSpecialtyAsync(SpecialtyCreationDTO specialtyCreationDTO)
        {
            var result = await _specialtyService.AddAsync(specialtyCreationDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSpecialtyAsync()
        {
            var result = await _specialtyService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdSpecialtyAsync(long id) 
        {
            var result = await _specialtyService.GetByIdAsync(id);

            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSpecialtyAsync(SpecialtyModificationDTO specialtyModificationDTO,long id)
        {
            var result = await _specialtyService.UpdateAsync(specialtyModificationDTO,id);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecialtyAsync(long id)
        {
            var result = await _specialtyService.DeleteAsync(id);

            return Ok(result);
        }
    }
}
