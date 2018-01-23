using System;
using System.ComponentModel.DataAnnotations;

namespace CohesiveSoftware.Data.Model
{
    public class AuditUpdateBase
    {
        [Display(Name = "Updated")]
        public DateTimeOffset? Updated { get; set; }

        [Display(Name = "Updated By")]
        public string UpdatedBy { get; set; }

        public void Update(string user)
        {
            Updated = DateTime.UtcNow;
            UpdatedBy = user;
        }
    }
}
