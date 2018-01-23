using System;
using System.ComponentModel.DataAnnotations;

namespace CohesiveSoftware.Data.Model
{
    public class AuditCreateUpdateDeleteNotRequiredBase : AuditUpdateBase
    {
        [Display(Name = "Created")]
        public DateTimeOffset? Created { get; set; }
        
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        public void Create(string user)
        {
            Created = DateTime.UtcNow;
            CreatedBy = user;
        }
    }
}
