using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    [Table("learningpathlinks")]
    internal class Learningpathlink : BaseAuditableEntity
    {
        //user_id uuid NOT NULL DEFAULT gen_random_uuid(),
        [Column("path_id")]
        public virtual Guid Id { get; set; }
        
        [Column("platfrom_id")]
        public Guid PlatfromId { get; set; }
        public string course_tittle { get; set; }
        public string course_link { get; set; }
        public string profile_info { get; set; }

        public virtual Platform Platform {get; set;}
    }
}