namespace Domain.Exceptions.Email
{
    public class EmailNotFound : GlobalException
    {
        public EmailNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Email Not Found !";
        }
    }
}