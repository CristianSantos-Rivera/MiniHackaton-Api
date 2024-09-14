using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    [Table("users")]
    internal class User : BaseAuditableEntity
    {
        //user_id uuid NOT NULL DEFAULT gen_random_uuid(),
        [Key]
        public Guid user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string profile_info { get; set; }
    }
}
