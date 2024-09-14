using System.ComponentModel.DataAnnotations;

namespace MiniHackaton.Domain.Common
{
    public class BaseEntity
    {
        public BaseEntity() 
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}
