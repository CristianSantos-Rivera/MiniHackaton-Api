using MiniHackaton.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniHackaton.Domain.Entities
{
    public class Student : BaseAuditableEntity
    {
        [Column("student_id")]
        public virtual Guid Id { get; set; }
    //public string bio { get; set; }
    //    user_id uuid NOT NULL REFERENCES public.users(user_id) ON DELETE CASCADE,
    //created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    //CONSTRAINT students_pkey PRIMARY KEY(student_id)
    }
}
