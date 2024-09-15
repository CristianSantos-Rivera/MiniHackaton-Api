using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    [Table("studentlearningpaths")]
    public class StudenLearningPath : BaseAuditableEntity
    {
        [Column("student_id")]
        public virtual Guid StudentId { get; set; }

        [Key]
        [Column("path_id")]
        public Guid LearningPathId { get; set; }

        public DateTime enrolled_at { get; set; }
        public decimal Ranking { get; set; }

        public virtual Student Student { get; set; }
        public virtual LearningPath LearningPath { get; set; }
    }
}
