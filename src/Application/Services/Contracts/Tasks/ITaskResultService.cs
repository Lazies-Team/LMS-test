using Application.DataTransferObjects.Lessons;
using Domain.Entities.Lessons;

namespace Application.Services.Contracts.Tasks
{
    public interface ITaskResultService
    {
        ValueTask<Attendance> AddAsync(AttendanceCreationDTO attendanceCreationDTO);
        ValueTask<List<Attendance>> GetAllAsync();
        ValueTask<Attendance> GetByIdAsync(long id);
        ValueTask<Attendance> UpdateAsync(AttendanceModificationDTO attendanceModificationDTO, long id);
        ValueTask<Attendance> DeleteAsync(long id);
    }
}
