namespace Domain.Exceptions.Users.Role
{
    public class RoleNotFound : GlobalException
    {
        public RoleNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Role Not Found !";
        }
    }
}