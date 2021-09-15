using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Domain.Seeds
{
   public abstract class BaseEntity <T> where T: BaseAuditableModels
    {

        public virtual int Id { get; set; }

        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedbyUserGuid { get; set; }
        public int? LastModifiedByUserGuid { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public abstract T MapToModel();
        public abstract T MapToModel(T t);
    }
}
