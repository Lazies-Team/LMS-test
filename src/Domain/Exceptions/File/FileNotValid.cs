namespace Domain.Exceptions.File
{
    public class FileNotValid : GlobalException
    {
        public FileNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "File Format Not Valid !";
        }
    }
}