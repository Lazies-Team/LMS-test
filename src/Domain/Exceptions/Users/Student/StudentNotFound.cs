namespace Domain.Exceptions.Users.Student
{
    public class StudentNotFound : GlobalException
    {
        public StudentNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Student Not Found !";
        }
    }
}