using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class Department
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int DepID { get; set; }
        [StringLength(50)]
        public string? DepName { get; set; }
        public int SubCode { get; set; }
        public virtual Subjects Subjects {  get; set; } 

    }
}
