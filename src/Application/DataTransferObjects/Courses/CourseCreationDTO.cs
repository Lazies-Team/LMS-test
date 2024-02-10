namespace Application.DataTransferObjects.Courses
{
    public record CourseCreationDTO
    (
        string Name,
        long SpecialityId,
        TimeOnly LessonStartAt,
        TimeOnly LessonEndAt,
        DateOnly StartAt,
        DateOnly EndAt
    );
}