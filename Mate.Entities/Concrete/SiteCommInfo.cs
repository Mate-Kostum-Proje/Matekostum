using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class SiteCommInfo : BaseEntity
    {
        public string Phone { get; set; }
        public string GSM1 { get; set; }
        public string GSM2 { get; set; }
        public string GSM3 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Transportation { get; set; }
        public string WorkingHours { get; set; }
        public string SocialMedias { get; set; }
    }
}
