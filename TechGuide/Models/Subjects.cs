using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class Subjects
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int SubCode { get; set; }
        [StringLength(50)]
        public string? SubName { get; set; }
        [ForeignKey("Chapters")]
        public int ChapterID { get; set; }
        public virtual Chapters Chapters { get; set; }
    }
}
