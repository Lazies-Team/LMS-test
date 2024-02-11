namespace Domain.Exceptions.Task
{
    public class GradeNotFound : GlobalException
    {
        public GradeNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Grade Not Found";
        }
    }
}