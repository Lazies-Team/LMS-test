using Domain.Comman;

namespace Domain.Entities.Users
{
    public class Admin : Auditable
    {
        public long UserId { get; set; }
    }
}
