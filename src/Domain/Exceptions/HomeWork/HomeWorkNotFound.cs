namespace Domain.Exceptions.HomeWork
{
    public class HomeWorkNotFound : GlobalException
    {
        public HomeWorkNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "HomeWork Not Found !";
        }
    }
}