using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeBase_MVC.Models
{
    public class ConnectionCompanyService
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameCompany { get; set; }

        [ForeignKey("NameCompany")]
        public Company Company { get; set; }


        [Required]
        [MaxLength(100)]
        public string NameService { get; set; }

        [Required]
        [ForeignKey("NameService")]
        public Service Service { get; set; }
    }
}
