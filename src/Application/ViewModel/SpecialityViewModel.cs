using Domain.Entities.Courses;

namespace Application.ViewModel
{
    public record SpecialityViewModel
    (
        long id,
        string Name,
        DateTime CreatedAt,
        DateTime UpdatedAt,
        ICollection<Course> Courses
    );
    
}
