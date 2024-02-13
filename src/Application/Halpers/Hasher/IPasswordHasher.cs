namespace Application.Halpers.Hasher
{
    public interface IPasswordHasher
    {
        string Encrypt(string password, string salt);
        bool Verify(string hash, string password, string salt);
    }
}
