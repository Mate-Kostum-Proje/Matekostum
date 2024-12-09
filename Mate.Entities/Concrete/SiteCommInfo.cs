using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class SiteCommInfo : BaseEntity
    {
        public string Phone { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public string WorkingHours { get; set; }
        public string SocialMedias { get; set; }
    }
}
