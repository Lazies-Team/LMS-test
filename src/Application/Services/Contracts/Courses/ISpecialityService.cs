using Application.DataTransferObjects.Courses;
using Application.ViewModel;

namespace Application.Services.Contracts.Courses
{
    public interface ISpecialityService
    {
        ValueTask<SpecialityViewModel> AddAsync(SpecialityCreationDTO specialtyCreationDTO);
        ValueTask<List<SpecialityViewModel>> GetAllAsync();
        ValueTask<SpecialityViewModel> GetByIdAsync(long id);
        ValueTask<SpecialityViewModel> UpdateAsync(SpecialityModificationDTO specialtyModificationDTO, long id);
        ValueTask<SpecialityViewModel> DeleteAsync(long id);
    }
}
