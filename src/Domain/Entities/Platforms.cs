using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    [Table("platforms")]
    public class Platform
    {
        //user_id uuid NOT NULL DEFAULT gen_random_uuid(),
        [Column("path_id")]
        public virtual Guid Id { get; set; }

        public string platfrom_name { get; set; }
        
    }
}