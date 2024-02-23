using Application.DataTransferObjects.Lessons;
using Application.ViewModel.Lessons;

namespace Application.Services.Contracts.Lessons
{
    public interface IAttendanceService
    {
        ValueTask<AttendanceViewModel> AddAsync(AttendanceCreationDTO attendanceCreationDTO);
        ValueTask<List<AttendanceViewModel>> GetAllAsync();
        ValueTask<AttendanceViewModel> GetByIdAsync(long id);
        ValueTask<AttendanceViewModel> UpdateAsync(AttendanceModificationDTO attendanceModificationDTO, long id);
        ValueTask<AttendanceViewModel> DeleteAsync(long id);
    }
}
