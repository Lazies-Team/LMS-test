using Application.Abstractions.Lessons;
using Application.DataTransferObjects.Lessons;
using Application.Services.Contracts.Lessons;
using Application.ViewModel;

using Domain.Entities.Lessons;

using Mapster;

namespace Application.Services.Lessons
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceService _attendanceService;
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceService(IAttendanceService attendanceService, IAttendanceRepository attendanceRepository = null)
        {
            _attendanceService = attendanceService;
            _attendanceRepository = attendanceRepository;
        }

        public async ValueTask<AttendanceViewModel> CreateAsync(AttandanceCreationDTO attendanceCreationDTO)
        {
            var attendance = attendanceCreationDTO.Adapt<Attendance>();
            var result = await _attendanceRepository.InsertAsync(attendance);
            var attendanceViewModel = result.Adapt<AttendanceViewModel>();

            return attendanceViewModel;
        }

        public async ValueTask<AttendanceViewModel> DeleteAsync(long id)
        {
            var result = await _attendanceRepository.DeleteAsync(id);
            var attendanceViewModel = result.Adapt<AttendanceViewModel>();

            return attendanceViewModel;
        }

        public async ValueTask<List<AttendanceViewModel>> GetAllAsync()
        {
            var result = _attendanceRepository.SelectAll();
            var attendanceViewModels = result.ToList().Adapt<List<AttendanceViewModel>>();

            return attendanceViewModels;
        }

        public async ValueTask<AttendanceViewModel> GetByIdAsync(long id)
        {
            var result = await _attendanceRepository.SelectByIdAsync(id);
            var attendanceViewModel = result.Adapt<AttendanceViewModel>();

            return attendanceViewModel;
        }

        public async ValueTask<AttendanceViewModel> UpdateAsync(AttandanceModificationDTO attandanceModificationDTO, long id)
        {
            var attendance = attandanceModificationDTO.Adapt<Attendance>();
            attendance.Id = id;
            var result = await _attendanceRepository.UpdateAsync(attendance);
            var attendanceViewModel = result.Adapt<AttendanceViewModel>();

            return attendanceViewModel;
        }
    }
}
