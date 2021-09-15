using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Studmgt.Domain.Seeds
{
    public abstract class BaseAuditableModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {protected set; get;}
   
        public int? CreatedBy { set; get; }
        public DateTime? CreatedDate { set; get; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActive { get; set; }

    }
}
