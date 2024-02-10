namespace Domain.Exceptions.Course
{
    public class CourseNotFound : GlobalException
    {
        public CourseNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Course Not Found !";
        }
    }
}