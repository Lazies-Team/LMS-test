using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Domain.Entities.Users;
using Mapster;

namespace Application.Services.Users
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
            => _studentRepository = studentRepository;

        public async ValueTask<List<Student>> GetAllAsync()
        {
            var result = _studentRepository.SelectAll().ToList();

            return result;
        }

        public async ValueTask<Student> GetByIdAsync(long id)
        {
            var result = await _studentRepository.SelectByIdAsync(id);

            return result;
        }

        public async ValueTask<Student> UpdateAsync(StudentModificationDTO studentModificationDTO, long id)
        {
            var student = studentModificationDTO.Adapt<Student>();
            student.Id = id;

            var result = await _studentRepository.UpdateAsync(student);

            return result;
        }

        public async ValueTask<Student> DeleteAsync(long id)
        {
            var result = await _studentRepository.DeleteAsync(id);

            return result;
        }
    }
}
