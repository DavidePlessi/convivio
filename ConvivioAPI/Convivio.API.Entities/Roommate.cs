using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Convivio.API.Entities
{
    [Table("Roommates")]
    public class Roommate : Entity
    {
        [Column("Name")] 
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
        
        [Column("Surname")] 
        [MaxLength(20)]
        [Required]
        public string Surname { get; set; }
        
        [Column("Tel")] 
        [EmailAddress]
        public string Tel { get; set; }
        
        [Column("Mail")] 
        [Phone]
        public string Mail { get; set; }
    }
}