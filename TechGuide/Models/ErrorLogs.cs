using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class ErrorLogs
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int ErrorID { get; set; }
        [StringLength(255)]
        public string? ErrorMessage { get; set; }
        public DateTime ErrorDate {  get; set; }
        [ForeignKey("Users")]
        public int UserID {  get; set; }
        public virtual Users Users { get; set; }
    }
}
