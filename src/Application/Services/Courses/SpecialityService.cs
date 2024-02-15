using Application.Abstractions.Courses;
using Application.DataTransferObjects.Courses;
using Application.Services.Contracts.Courses;
using Application.ViewModel;
using Domain.Entities.Courses;
using Mapster;

namespace Application.Services.Courses
{
    public class SpecialityService : ISpecialityService
    {
        private readonly ISpecialityRepository _specialityRepository;

        public SpecialityService(ISpecialityRepository specialityRepository)
            => _specialityRepository = specialityRepository;

        public async ValueTask<SpecialityViewModel> AddAsync(SpecialityCreationDTO specialtyCreationDTO)
        {
            var specialty = specialtyCreationDTO.Adapt<Speciality>();
            var created = await _specialityRepository.InsertAsync(specialty);
            var specialityViewModel = created.Adapt<SpecialityViewModel>();

            return specialityViewModel;
        }

        public async ValueTask<SpecialityViewModel> DeleteAsync(long id)
        {
            var specialty = await _specialityRepository.DeleteAsync(id);
            var result = specialty.Adapt<SpecialityViewModel>();

            return result;
        }

        public async ValueTask<List<SpecialityViewModel>> GetAllAsync()
        {
            var specialtys = _specialityRepository.SelectAll();
            var result = specialtys.ToList().Adapt<List<SpecialityViewModel>>();

            return result;
        }

        public async ValueTask<SpecialityViewModel> GetByIdAsync(long id)
        {
            var specialty = await _specialityRepository.SelectByIdAsync(id);
            var result = specialty.Adapt<SpecialityViewModel>();

            return result;
        }

        public async ValueTask<SpecialityViewModel> UpdateAsync(SpecialityModificationDTO specialtyModificationDTO, long id)
        {
            var specialty = specialtyModificationDTO.Adapt<Speciality>();
            specialty.Id = id;
            var update = _specialityRepository.UpdateAsync(specialty);
            var result = update.Adapt<SpecialityViewModel>();

            return result;
        }
    }
}
