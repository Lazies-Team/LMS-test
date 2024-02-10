namespace Domain.Exceptions.Email
{
    public class EmailAlreadyExists : GlobalException
    {
        public EmailAlreadyExists()
        {
            StatusCode = System.Net.HttpStatusCode.Conflict;
            TitleMessage = "Email Already Exists !";
        }
    }
}