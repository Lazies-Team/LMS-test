using Application.ViewModel.Lessons;
using Application.ViewModel.Users;
using Domain.Entities.Courses;

namespace Application.ViewModel.Courses
{
    public record CourseViewModel(
        long Id,
        string Name,
        long SpecialityId,
        TimeOnly LessonStartAt,
        TimeOnly LessonEndAt,
        DateOnly StartAt,
        DateOnly EndAt,
        Speciality Specialty,
        ICollection<LessonViewModel> Lessons,
        ICollection<TeacherViewModel> Teachers,
        ICollection<StudentViewModel> Students
    );
}
