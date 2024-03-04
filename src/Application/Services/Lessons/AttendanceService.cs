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
            var result = attendances.Adapt<Attendance>();

            return result;
        }

        public async ValueTask<Attendance> DeleteAsync(long id)
        {
            var attendance = await _attendanceRepository.DeleteAsync(id);
            var result = attendance.Adapt<Attendance>();

            return result;
        }

        public async ValueTask<List<Attendance>> GetAllAsync()
        {
            var attendance = _attendanceRepository.SelectAll();
            var attendaces = attendance.ToList().Adapt<List<Attendance>>();

            return attendaces;
        }

        public async ValueTask<Attendance> GetByIdAsync(long id)
        {
            var attendance = await _attendanceRepository.SelectByIdAsync(id);
            var result = attendance.Adapt<Attendance>();

            return result;
        }

        public async ValueTask<Attendance> UpdateAsync(AttendanceModificationDTO attendanceModificationDTO, long id)
        {
            var attendance = attendanceModificationDTO.Adapt<Attendance>();
            attendance.Id = id;
            var attendances = await _attendanceRepository.UpdateAsync(attendance);
            var result = attendances.Adapt<Attendance>();

            return result;
        }
    }
}
