using Application.DataTransferObjects.Courses;
using Application.ViewModel;

namespace Application.Services.Contracts.Courses
{
    public interface ICourseService
    {
        ValueTask<CourseViewModel> AddAsync(CourseCreationDTO courseCreationDTO);
        ValueTask<List<CourseViewModel>> GetAllAsync();
        ValueTask<CourseViewModel> GetByIdAsync(long id);
        ValueTask<CourseViewModel> UpdateAsync(CourseModificationDTO courseModificationDTO, long id);
        ValueTask<CourseViewModel> DeleteAsync(long id);
    }
}
