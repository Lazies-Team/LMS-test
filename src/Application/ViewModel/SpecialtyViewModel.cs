using Domain.Entities.Courses;

namespace Application.ViewModel
{
    public record SpecialtyViewModel
    (
        long id,
        string Name,
        DateTime CreatedAt,
        DateTime UpdatedAt,
        ICollection<Course> Courses
    );
    
}
