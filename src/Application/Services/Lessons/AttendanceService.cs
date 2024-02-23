using Application.Abstractions.Lessons;
using Application.DataTransferObjects.Lessons;
using Application.Services.Contracts.Lessons;
using Application.ViewModel.Lessons;
using Domain.Entities.Lessons;
using Application.ViewModel;
using Mapster;

namespace Application.Services.Lessons
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceService(IAttendanceRepository attendanceRepository)
            => _attendanceRepository = attendanceRepository;

        public async ValueTask<AttendanceViewModel> AddAsync(AttendanceCreationDTO attendanceCreationDTO)
        {
            var attendance = attendanceCreationDTO.Adapt<Attendance>();
            var attendances = await _attendanceRepository.InsertAsync(attendance);
            var result = attendances.Adapt<AttendanceViewModel>();

            return result;
        }

        public async ValueTask<AttendanceViewModel> DeleteAsync(long id)
        {
            var attendance = await _attendanceRepository.DeleteAsync(id);
            var attendanceviewmodel = attendance.Adapt<AttendanceViewModel>();

            return attendanceviewmodel;
        }

        public async ValueTask<List<AttendanceViewModel>> GetAllAsync()
        {
            var attendance = _attendanceRepository.SelectAll();
            var attendaces = attendance.ToList().Adapt<List<AttendanceViewModel>>();

            return attendaces;
        }

        public async ValueTask<AttendanceViewModel> GetByIdAsync(long id)
        {
            var attendance = await _attendanceRepository.SelectByIdAsync(id);
            var result = attendance.Adapt<AttendanceViewModel>();

            return result;
        }

        public async ValueTask<AttendanceViewModel> UpdateAsync(AttendanceModificationDTO attendanceModificationDTO, long id)
        {
            var attendance = attendanceModificationDTO.Adapt<Attendance>();
            attendance.Id = id;
            var attendances = await _attendanceRepository.UpdateAsync(attendance);
            var result = attendances.Adapt<AttendanceViewModel>();

            return result;
        }
    }
}
