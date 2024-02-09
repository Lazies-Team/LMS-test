namespace Domain.Exceptions.Email
{
    public class EmailNotValid : GlobalException
    {
        public EmailNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "Email Not Valid !";
        }
    }
}