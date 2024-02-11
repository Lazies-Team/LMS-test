namespace Domain.Exceptions.Course
{
    public class SpecialtyNotFound : GlobalException
    {
        public SpecialtyNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Specialty Not Found !";
        }
    }
}