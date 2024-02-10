namespace Domain.Exceptions.PhoneNumber
{
    public class PhoneNumberNotFound : GlobalException
    {
        public PhoneNumberNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Phone Number Not Found !";
        }
    }
}