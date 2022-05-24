using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeBase_MVC.Models
{
    public class Company
    {
        [Key]
        [MaxLength(100)]
        public string NameCompany { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string OccupationOfTheCompany { get; set; }

        [Required]
        [MaxLength(100)]
        public string Location { get; set; }
    }
}
