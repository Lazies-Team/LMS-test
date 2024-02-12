namespace Domain.Exceptions.Image
{
    public class ImageNotValid : GlobalException
    {
        public ImageNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "Image Format Not Valid !";
        }
    }
}