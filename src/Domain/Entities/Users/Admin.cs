using Domain.Comman;

namespace Domain.Entities.Users
{
    public class Admin : Auditable
    {
        public long UserId { get; set; }

        public virtual User User { get; set; }
    }
}
