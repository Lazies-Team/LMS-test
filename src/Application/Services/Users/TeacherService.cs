using Application.Abstractions.Users;
using Application.DataTransferObjects.Users;
using Application.Services.Contracts.Users;
using Domain.Entities.Users;
using Mapster;

namespace Application.Services.Users
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
            => _teacherRepository = teacherRepository;


        public async ValueTask<List<Teacher>> GetAllAsync()
        {
            var result = _teacherRepository.SelectAll().ToList();

            return result;
        }

        public async ValueTask<Teacher> GetByIdAsync(long id)
        {
            var result = await _teacherRepository.SelectByIdAsync(id);

            return result;
        }

        public async ValueTask<Teacher> UpdateAsync(TeacherModificationDTO teacherModificationDTO, long id)
        {
            var teacher = teacherModificationDTO.Adapt<Teacher>();
            teacher.Id = id;

            var result = await _teacherRepository.UpdateAsync(teacher);

            return result;
        }

        public async ValueTask<Teacher> DeleteAsync(long id)
        {
            var result = await _teacherRepository.DeleteAsync(id);

            return result;
        }
    }
}
