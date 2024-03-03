using Application.DataTransferObjects.Courses;
using Domain.Entities.Courses;

namespace Application.Services.Contracts.Courses
{
    public interface ICourseService
    {
        ValueTask<Course> AddAsync(CourseCreationDTO courseCreationDTO);
        ValueTask<List<Course>> GetAllAsync();
        ValueTask<Course> GetByIdAsync(long id);
        ValueTask<Course> UpdateAsync(CourseModificationDTO courseModificationDTO, long id);
        ValueTask<Course> DeleteAsync(long id);
    }
}
