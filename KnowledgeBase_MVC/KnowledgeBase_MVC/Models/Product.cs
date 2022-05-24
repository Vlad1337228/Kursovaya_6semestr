using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeBase_MVC.Models
{
    public class Product
    {
        [Key]
        [MaxLength(100)]
        public string EAN { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string NameProduct { get; set; }

        [Required]
        public decimal Coast { get; set; }
    }
}
