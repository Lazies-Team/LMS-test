using Application.Abstractions.Courses;
using Application.DataTransferObjects.Courses;
using Application.Services.Contracts.Courses;
using Application.ViewModel;
using Domain.Entities.Courses;
using Mapster;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Application.Services.Courses
{
    public class SpecialtyService : ISpecialtyService
    {
        private readonly ISpecialtyRepository _specialtyRepository;

        public SpecialtyService(ISpecialtyRepository specialtyRepository)
            => _specialtyRepository = specialtyRepository;

        public async ValueTask<SpecialtyViewModel> AddAsync(SpecialtyCreationDTO specialtyCreationDTO)
        {
            var specialty = specialtyCreationDTO.Adapt<Specialty>();
            var created = await _specialtyRepository.InsertAsync(specialty);
            var specialityViewModel = created.Adapt<SpecialtyViewModel>();

            return specialityViewModel;
        }

        public async ValueTask<SpecialtyViewModel> DeleteAsync(long id)
        {
            var specialty = await _specialtyRepository.DeleteAsync(id);
            var result = specialty.Adapt<SpecialtyViewModel>();

            return result;
        }

        public async ValueTask<List<SpecialtyViewModel>> GetAllAsync()
        {
            var specialtys = _specialtyRepository.SelectAll();
            var result = specialtys.ToList().Adapt<List<SpecialtyViewModel>>();

            return result;
        }

        public async ValueTask<SpecialtyViewModel> GetByIdAsync(long id)
        {
            var specialty = await _specialtyRepository.SelectByIdAsync(id);
            var result = specialty.Adapt<SpecialtyViewModel>();

            return result;
        }

        public async ValueTask<SpecialtyViewModel> UpdateAsync(SpecialtyModificationDTO specialtyModificationDTO, long id)
        {
            var specialty = specialtyModificationDTO.Adapt<Specialty>();
            specialty.Id = id;
            var update = _specialtyRepository.UpdateAsync(specialty);
            var result = update.Adapt<SpecialtyViewModel>();

            return result;
        }
    }
}
