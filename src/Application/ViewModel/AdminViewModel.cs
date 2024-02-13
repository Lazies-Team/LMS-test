using Domain.Entities.Users;

namespace Application.ViewModel
{
    public class AdminViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; }
    }
}
