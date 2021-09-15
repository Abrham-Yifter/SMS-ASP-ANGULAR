using Studmgt.Domain.Enum;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Studmgt.Domain.Model
{
    public class Enrollment: BaseAuditableModels
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}
