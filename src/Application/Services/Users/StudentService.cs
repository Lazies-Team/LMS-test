using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Application.ViewModel;
using Domain.Entities.Users;
using Mapster;

namespace Application.Services.Users
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
            => _studentRepository = studentRepository;

        public async ValueTask<List<StudentViewModel>> GetAllAsync()
        {
            var result = _studentRepository.SelectAll();
            var studentViewModels = result.ToList().Adapt<List<StudentViewModel>>();

            return studentViewModels;
        }

        public async ValueTask<StudentViewModel> GetByIdAsync(long id)
        {
            var result = await _studentRepository.SelectByIdAsync(id);
            var studentViewModel = result.Adapt<StudentViewModel>();

            return studentViewModel;
        }

        public async ValueTask<StudentViewModel> UpdateAsync(StudentModificationDTO studentModificationDTO, long id)
        {
            var student = studentModificationDTO.Adapt<Student>();
            student.Id = id;

            var result = await _studentRepository.UpdateAsync(student);
            var studentViewModel = result.Adapt<StudentViewModel>();

            return studentViewModel;
        }

        public async ValueTask<StudentViewModel> DeleteAsync(long id)
        {
            var result = await _studentRepository.DeleteAsync(id);
            var studentViewModel = result.Adapt<StudentViewModel>();

            return studentViewModel;
        }
    }
}
