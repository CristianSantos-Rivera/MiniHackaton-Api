using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Common
{
    public class BaseAuditableEntity : BaseEntity
    {
        public BaseAuditableEntity() : base()
        {
            DateTime date = DateTime.UtcNow;
            DateCreated = date;
            
        }

        
        

        [Column("created_at")]
        public DateTime DateCreated { get; set; }
    }
        
}
