using Domain.Entities.Courses;
using Domain.Entities.Lessons;
using Domain.Entities.Users;

namespace Application.ViewModel
{
    public record CourseViewModel(
        long Id,
        string Name,
        long SpecialityId,
        TimeOnly LessonStartAt,
        TimeOnly LessonEndAt,
        DateOnly StartAt,
        DateOnly EndAt,

        Specialty Specialty,
        ICollection<Lesson> Lessons,
        ICollection<Teacher> Teachers,
        ICollection<Student> Students
    );
}
