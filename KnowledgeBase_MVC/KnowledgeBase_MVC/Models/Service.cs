using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeBase_MVC.Models
{
    public class Service
    {
        [Key]
        [MaxLength(100)]
        public string NameService { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public decimal Coast { get; set; }
    }
}
