namespace Mate.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTime? CreatedAt { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
