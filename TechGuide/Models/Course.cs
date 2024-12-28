using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class Course
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int CourseID { get; set; }
        [StringLength(40)]
        public string? CourseName { get; set; }
        [ForeignKey("Semester")]
        public int  SemesterID { get; set; }
        public virtual Semester Semester { get; set; }
        [ForeignKey("Types")]
        public int TypeID { get; set; }
        public virtual Types Types { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<CoursePrerequisites>? CoursePrerequisites { get; set; }
    }
}
