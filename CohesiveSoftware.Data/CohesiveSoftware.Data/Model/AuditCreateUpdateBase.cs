using System;
using System.ComponentModel.DataAnnotations;

namespace CohesiveSoftware.Data.Model
{
    public class AuditCreateUpdateBase : AuditUpdateBase
    {
        [Required]
        [Display(Name = "Created")]
        public DateTimeOffset Created { get; set; }

        [Required]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        public void Create(string user)
        {
            Created = DateTime.UtcNow;
            CreatedBy = user;
        }
    }
}
