using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechGuide.Models
{
    public class Users
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int UserID {  get; set; }
        [StringLength(50)]
        public string? UserName { get; set; }
        [StringLength(256)]
        public char Password { get; set; }
        public bool Role {  get; set; }
        public DateTime CreateDate { get; set; }

    }
}
