namespace Domain.Exceptions.Lesson
{
    public class LessonNotFound : GlobalException
    {
        public LessonNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Lesson Not Found !";
        }
    }
}