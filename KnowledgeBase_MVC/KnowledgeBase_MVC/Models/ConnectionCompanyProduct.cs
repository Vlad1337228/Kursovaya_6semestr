using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeBase_MVC.Models
{
    public class ConnectionCompanyProduct
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
        public string EAN { get; set; }

        [Required]
        [ForeignKey("EAN")]
        public Product Product { get; set; }
    }
}
