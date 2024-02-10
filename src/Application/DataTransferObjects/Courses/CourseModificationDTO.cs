namespace Application.DataTransferObjects.Courses
{
    public record class CourseModificationDTO
    (
        long Id,
        string Name,
        long SpecialityId,
        TimeOnly LessonStartAt,
        TimeOnly LessonEndAt,
        DateOnly StartAt,
        DateOnly EndAt
    );
}