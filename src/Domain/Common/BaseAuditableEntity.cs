using System.ComponentModel;

namespace MiniHackaton.Domain.Common
{
    public class BaseAuditableEntity : BaseEntity
    {
        public BaseAuditableEntity() : base()
        {
            DateTime date = DateTime.UtcNow;
            DateCreated = date;
            DateUpdated = date;
            IsActive = true;
        }

        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}
