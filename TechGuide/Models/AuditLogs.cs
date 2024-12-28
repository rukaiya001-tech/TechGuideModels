using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class AuditLogs
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int LogID { get; set; }
        [StringLength(50)]
        public string? TableName { get; set; }
        [StringLength(20)]
        public string? Operation { get; set; }
        public DateTime OperationDate { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
        public virtual Users Users { get; set; }


    }
}
