using System;
using System.ComponentModel.DataAnnotations;

namespace CohesiveSoftware.Data.Model
{
    public class AuditCreateUpdateDeleteBase : AuditCreateUpdateBase
    {
        [Display(Name = "Deleted")]
        public DateTimeOffset? Deleted { get; set; }

        [Display(Name = "Deleted By")]
        public string DeletedBy { get; set; }

        public void Delete(string user)
        {
            Deleted = DateTime.UtcNow;
            DeletedBy = user;
        }

        public void Restore(string user)
        {
            Deleted = null;
            UpdatedBy = user;
        }
    }
}
