namespace Domain.Exceptions.Users.User
{
    public class UserNotFound : GlobalException
    {
        public UserNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "User Not Found !";
        }
    }
}