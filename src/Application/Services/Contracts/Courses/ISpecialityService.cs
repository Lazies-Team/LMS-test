using Application.DataTransferObjects.Courses;
using Domain.Entities.Courses;

namespace Application.Services.Contracts.Courses
{
    public interface ISpecialityService
    {
        ValueTask<Speciality> AddAsync(SpecialityCreationDTO specialtyCreationDTO);
        ValueTask<List<Speciality>> GetAllAsync();
        ValueTask<Speciality> GetByIdAsync(long id);
        ValueTask<Speciality> UpdateAsync(SpecialityModificationDTO specialtyModificationDTO, long id);
        ValueTask<Speciality> DeleteAsync(long id);
    }
}
