namespace Mate.Entities.Abstract
{
    public class BaseEntity
    {
        public string GuidId { get; set; }
        public DateTime CreatedAt { get; set; }

        protected BaseEntity()
        {
            GuidId = Guid.NewGuid().ToString();
        }
    }
}
