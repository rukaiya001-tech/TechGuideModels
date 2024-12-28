using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class Types
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int TypeID { get; set; }
        [StringLength(20)]
        public string? TypeName { get; set; }
    }
}
