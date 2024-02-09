namespace Domain.Exceptions.PhoneNumber
{
    public class PhoneNumberNotValid : GlobalException
    {
        public PhoneNumberNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "Phone Number Not Valid !";
        }
    }
}
