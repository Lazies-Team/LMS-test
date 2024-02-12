namespace Domain.Exceptions.Users.Teacher
{
    public class TeacherNotFound : GlobalException
    {
        public TeacherNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Teacher Not Found !";
        }
    }
}