namespace Domain.Exceptions.Password
{
    public class PasswordNotValid : GlobalException
    {
        public PasswordNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "Password Must be 8 Letters and Uppercase Letter !";
        }
    }
}