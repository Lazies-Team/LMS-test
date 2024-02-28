using Application.Abstractions.Lessons;
using Application.DataTransferObjects.Lessons;
using Application.Services.Contracts.Lessons;
using Application.ViewModel.Lessons;
using Domain.Entities.Lessons;
using Mapster;

namespace Application.Services.Lessons
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceService(IAttendanceRepository attendanceRepository)
            => _attendanceRepository = attendanceRepository;

        public async ValueTask<ViewModel.Lessons.AttendanceViewModel> AddAsync(AttendanceCreationDTO attendanceCreationDTO)
        {
            var attendance = attendanceCreationDTO.Adapt<Attendance>();
            var attendances = await _attendanceRepository.InsertAsync(attendance);
            var result = attendances.Adapt<ViewModel.Lessons.AttendanceViewModel>();

            return result;
        }

        public async ValueTask<ViewModel.Lessons.AttendanceViewModel> DeleteAsync(long id)
        {
            var attendance = await _attendanceRepository.DeleteAsync(id);
            var attendanceviewmodel = attendance.Adapt<ViewModel.Lessons.AttendanceViewModel>();

            return attendanceviewmodel;
        }

        public async ValueTask<List<ViewModel.Lessons.AttendanceViewModel>> GetAllAsync()
        {
            var attendance = _attendanceRepository.SelectAll();
            var attendaces = attendance.ToList().Adapt<List<ViewModel.Lessons.AttendanceViewModel>>();

            return attendaces;
        }

        public async ValueTask<ViewModel.Lessons.AttendanceViewModel> GetByIdAsync(long id)
        {
            var attendance = await _attendanceRepository.SelectByIdAsync(id);
            var result = attendance.Adapt<ViewModel.Lessons.AttendanceViewModel>();

            return result;
        }

        public async ValueTask<ViewModel.Lessons.AttendanceViewModel> UpdateAsync(AttendanceModificationDTO attendanceModificationDTO, long id)
        {
            var attendance = attendanceModificationDTO.Adapt<Attendance>();
            attendance.Id = id;
            var attendances = await _attendanceRepository.UpdateAsync(attendance);
            var result = attendances.Adapt<ViewModel.Lessons.AttendanceViewModel>();

            return result;
        }
    }
}
