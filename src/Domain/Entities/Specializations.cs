using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    [Table("specializations")]
    public class Specialization : BaseAuditableEntity
    {
        [Column("specialization_id")]
        public virtual Guid Id { get; set; }
        public string specialization_name { get; set; }
        
    }
}