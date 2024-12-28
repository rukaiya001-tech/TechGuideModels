using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class Semester
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int SemesterID { get; set; }
        [StringLength(50)]
        public string? SemesterName { get; set; }
        [StringLength(40)]
        public int DepID { get; set; }
        public virtual Department Department { get; set; }

    }
}
