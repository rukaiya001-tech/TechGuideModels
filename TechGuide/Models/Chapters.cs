using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class Chapters
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChapterID { get; set; }
        //[StringLength(50)]
        public string? ChapterName { get; set; }
        [StringLength(255)]
        public string? ChapterVideo { get; set; }
    }
}
