using Application.Abstractions.Courses;
using Application.DataTransferObjects.Courses;
using Application.Services.Contracts.Courses;
using Domain.Entities.Courses;
using Mapster;

namespace Application.Services.Courses
{
    public class SpecialityService : ISpecialityService
    {
        private readonly ISpecialityRepository _specialityRepository;

        public SpecialityService(ISpecialityRepository specialityRepository)
            => _specialityRepository = specialityRepository;

        public async ValueTask<Speciality> AddAsync(SpecialityCreationDTO specialtyCreationDTO)
        {
            var specialty = specialtyCreationDTO.Adapt<Speciality>();
            var result = await _specialityRepository.InsertAsync(specialty);

            return result;
        }

        public async ValueTask<Speciality> DeleteAsync(long id)
        {
            var specialty = await _specialityRepository.DeleteAsync(id);
            
            return specialty;
        }

        public async ValueTask<List<Speciality>> GetAllAsync()
        {
            var specialtys = _specialityRepository.SelectAll().ToList();

            return specialtys;
        }

        public async ValueTask<Speciality> GetByIdAsync(long id)
        {
            var specialty = await _specialityRepository.SelectByIdAsync(id);

            return specialty;
        }

        public async ValueTask<Speciality> UpdateAsync(SpecialityModificationDTO specialtyModificationDTO, long id)
        {
            var specialty = specialtyModificationDTO.Adapt<Speciality>();
            specialty.Id = id;

            var update = await _specialityRepository.UpdateAsync(specialty);

            return update;
        }
    }
}
