using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    public class Mentor : BaseAuditableEntity
    {
        [Column("mentor_id")]
        public virtual Guid Id { get; set; }
        public string bio { get; set; }
        public decimal ranking { get; set; }
    }
}
