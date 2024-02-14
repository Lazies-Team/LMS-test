using Application.DataTransferObjects.Courses;
using Application.DataTransferObjects.Users;
using Application.ViewModel;

namespace Application.Services.Contracts.Courses
{
    public interface ISpecialtyService
    {
        ValueTask<SpecialtyViewModel> AddAsync(SpecialtyCreationDTO specialtyCreationDTO);
        ValueTask<List<SpecialtyViewModel>> GetAllAsync();
        ValueTask<SpecialtyViewModel> GetByIdAsync(long id);
        ValueTask<SpecialtyViewModel> UpdateAsync(SpecialtyModificationDTO specialtyModificationDTO, long id);
        ValueTask<SpecialtyViewModel> DeleteAsync(long id);
    }
}
