using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    [Table("studentlearningpaths")]
    public class StudenLearningPath : BaseAuditableEntity
    {
        [Column("student_id")]
        public virtual Guid Id { get; set; }
       
    //path_id uuid NOT NULL,
    //enrolled_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    //    ranking integer DEFAULT 0,
    //CONSTRAINT studentlearningpaths_pkey PRIMARY KEY (student_id, path_id),
    //CONSTRAINT studentlearningpaths_path_id_fkey FOREIGN KEY (path_id)
    //    REFERENCES public.learningpaths(path_id) MATCH SIMPLE
    //    ON UPDATE NO ACTION
    //    ON DELETE CASCADE,
    //CONSTRAINT studentlearningpaths_student_id_fkey FOREIGN KEY(student_id)
    //    REFERENCES public.students(student_id) MATCH SIMPLE
    //    ON UPDATE NO ACTION
    //    ON DELETE CASCADE
    }
}
