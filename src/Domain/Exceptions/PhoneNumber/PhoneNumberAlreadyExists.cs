namespace Domain.Exceptions.PhoneNumber
{
    public class PhoneNumberAlreadyExists : GlobalException
    {
        public PhoneNumberAlreadyExists()
        {
            StatusCode = System.Net.HttpStatusCode.Conflict;
            TitleMessage = "Phone Number Already Exists !";
        }
    }
}