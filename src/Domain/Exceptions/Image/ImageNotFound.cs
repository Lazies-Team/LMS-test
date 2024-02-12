namespace Domain.Exceptions.Image
{
    public class ImageNotFound : GlobalException
    {
        public ImageNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Image Not Found !";
        }
    }
}