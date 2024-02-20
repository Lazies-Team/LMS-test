using Application.DataTransferObjects.Lessons;
using Application.Services.Contracts.Lessons;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;

        public AttendanceController(IAttendanceService attendanceService)
            => _attendanceService = attendanceService;

        [HttpPost]
        public async Task<IActionResult> PostAttendanceAsync(AttendanceCreationDTO attendanceCreationDTO)
        {
            var result = await _attendanceService.AddAsync(attendanceCreationDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAttendceAsync()
        {
            var result = await _attendanceService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIdAttendance(long Id)
        {
            var result = await _attendanceService.GetByIdAsync(Id);

            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateAttendanceAsync(AttendanceModificationDTO attendanceModificationDTO, long Id)
        {
            var result = await _attendanceService.UpdateAsync(attendanceModificationDTO, Id);

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAttendanceAsync(long Id)
        {
            var result = await _attendanceService.DeleteAsync(Id);

            return Ok(result);
        }
    }
}
