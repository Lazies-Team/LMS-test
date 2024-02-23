using Application.DataTransferObjects.Courses;
using Application.Services.Contracts.Courses;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SpecialityController : ControllerBase
    {
        private readonly ISpecialityService _specialityService;

        public SpecialityController(ISpecialityService specialityService)
            => _specialityService = specialityService;

        [HttpPost]
        public async Task<IActionResult> PostSpecialtyAsync(SpecialityCreationDTO specialtyCreationDTO)
        {
            var result = await _specialityService.AddAsync(specialtyCreationDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSpecialtyAsync()
        {
            var result = await _specialityService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdSpecialtyAsync(long id)
        {
            var result = await _specialityService.GetByIdAsync(id);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSpecialtyAsync(SpecialityModificationDTO specialtyModificationDTO, long id)
        {
            var result = await _specialityService.UpdateAsync(specialtyModificationDTO, id);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecialtyAsync(long id)
        {
            var result = await _specialityService.DeleteAsync(id);

            return Ok(result);
        }
    }
}
