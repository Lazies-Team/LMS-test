namespace Application.DataTransferObjects.Courses
{
    public record CourseModificationDTO
    (
        string Name,
        long SpecialityId,
        TimeOnly LessonStartAt,
        TimeOnly LessonEndAt,
        DateOnly StartAt,
        DateOnly EndAt
    );
}
