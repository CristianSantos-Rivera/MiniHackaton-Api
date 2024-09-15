using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    [Table("learningpaths")]
    public class LearningPath : BaseAuditableEntity
    {
        [Column("path_id")]
        public virtual Guid Id { get; set; }
        //mentor_id uuid,
        //specialization_id uuid,
        public string title { get; set; }
        public string description { get; set; }

        [Column("mentor_id")]
        public Guid MentorId { get; set; }

        public virtual Mentor Mentor { get; set; }

        [Column("specialization_id")]
        public Guid SpecializationId { get; set; }

        public virtual Specialization Specialization { get; set; }



}

    //CONSTRAINT learningpaths_specialization_id_fkey FOREIGN KEY(specialization_id)
    //    REFERENCES public.specializations(specialization_id) MATCH SIMPLE
    //    ON UPDATE NO ACTION
    //    ON DELETE CASCADE
    }

