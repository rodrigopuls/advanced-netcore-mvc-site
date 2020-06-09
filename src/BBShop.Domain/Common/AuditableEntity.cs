using System;

namespace BBShop.Domain.Common
{
    public class AuditableEntity
    {
        protected AuditableEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime Created { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
