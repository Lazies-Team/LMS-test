using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Application.ViewModel;
using Domain.Entities.Users;
using Mapster;

namespace Application.Services.Users
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
            => _teacherRepository = teacherRepository;        


        public async ValueTask<List<TeacherViewModel>> GetAllAsync()
        {
            var result = _teacherRepository.SelectAll();
            var teacherViewModels = result.ToList().Adapt<List<TeacherViewModel>>();

            return teacherViewModels;
        }

        public async ValueTask<TeacherViewModel> GetByIdAsync(long id)
        {   
            var result = await _teacherRepository.SelectByIdAsync(id);
            var teacherViewModel = result.Adapt<TeacherViewModel>();

            return teacherViewModel;
        }

        public async ValueTask<TeacherViewModel> UpdateAsync(TeacherModificationDTO teacherModificationDTO, long id)
        {
            var teacher = teacherModificationDTO.Adapt<Teacher>();
            teacher.Id = id;
            var result = await _teacherRepository.UpdateAsync(teacher);
            var teacherViewModel = result.Adapt<TeacherViewModel>(); 

            return teacherViewModel;
        }

        public async ValueTask<TeacherViewModel> DeleteAsync(long id)
        {
            var result = await _teacherRepository.DeleteAsync(id);
            var teacherViewModel = result.Adapt<TeacherViewModel>();

            return teacherViewModel;
        }
    }
}
