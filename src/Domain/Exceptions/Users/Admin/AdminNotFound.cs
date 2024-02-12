namespace Domain.Exceptions.Users.Admin
{
    public class AdminNotFound : GlobalException
    {
        public AdminNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Admin Not Found !";
        }
    }
}