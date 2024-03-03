using Application.Abstractions.Lessons;
using Application.DataTransferObjects.Lessons;
using Application.Services.Contracts.Lessons;
using Domain.Entities.Lessons;
using Mapster;

namespace Application.Services.Lessons
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceService(IAttendanceRepository attendanceRepository)
            => _attendanceRepository = attendanceRepository;

        public async ValueTask<Attendance> AddAsync(AttendanceCreationDTO attendanceCreationDTO)
        {
            var attendance = attendanceCreationDTO.Adapt<Attendance>();
            var attendances = await _attendanceRepository.InsertAsync(attendance);

            return attendances;
        }

        public async ValueTask<Attendance> DeleteAsync(long id)
        {
            var attendance = await _attendanceRepository.DeleteAsync(id);

            return attendance;
        }

        public async ValueTask<List<Attendance>> GetAllAsync()
        {
            var attendances = _attendanceRepository.SelectAll().ToList();

            return attendances;
        }

        public async ValueTask<Attendance> GetByIdAsync(long id)
        {
            var attendance = await _attendanceRepository.SelectByIdAsync(id);

            return attendance;
        }

        public async ValueTask<Attendance> UpdateAsync(AttendanceModificationDTO attendanceModificationDTO, long id)
        {
            var attendance = attendanceModificationDTO.Adapt<Attendance>();
            attendance.Id = id;

            var updated = await _attendanceRepository.UpdateAsync(attendance);

            return updated;
        }
    }
}
