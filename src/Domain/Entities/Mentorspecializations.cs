using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    [Table("mentorspecializations")]
    internal class Mentorspecialization : BaseAuditableEntity
    {
        //user_id uuid NOT NULL DEFAULT gen_random_uuid(),
        [Column("mentor_id")]
        public virtual Guid MentorId { get; set; }

        [Column("specialization_id")]
        public Guid SpecializationId { get; set; }
        
        //public virtual Specializations Specializations {get;set;}
    }
}