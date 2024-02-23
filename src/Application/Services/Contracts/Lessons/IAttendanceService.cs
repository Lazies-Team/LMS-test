using Application.DataTransferObjects.Lessons;
using Application.ViewModel;

namespace Application.Services.Contracts.Lessons
{
    public interface IAttendanceService
    {
        ValueTask<AttendanceViewModel> AddAsync(AttandanceCreationDTO attandanceCreationDTO);
        ValueTask<List<AttendanceViewModel>> GetAllAsync();
        ValueTask<AttendanceViewModel> GetByIdAsync(long id);
        ValueTask<AttendanceViewModel> UpdateAsync(AttandanceModificationDTO attandanceModificationDTO, long id);
        ValueTask<AttendanceViewModel> DeleteAsync(long id);
    }
}
