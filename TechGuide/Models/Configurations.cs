using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class Configurations
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int ConfigID { get; set; }
        [StringLength(50)]
        public string? ConfigKey { get; set; }
        [StringLength(255)]
        public string? ConfigValue { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
