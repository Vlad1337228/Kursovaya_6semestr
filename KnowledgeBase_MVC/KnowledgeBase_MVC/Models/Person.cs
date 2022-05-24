using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KnowledgeBase_MVC.Models
{
    public class Person
    {
        [Key]
        [MaxLength(100)]
        public string FIO { get; set; }

        [Required]
        [MaxLength(100)]
        public string Post { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameCompany { get; set; }

        [ForeignKey("NameCompany")]
        public Company Company { get; set; }
    }
}
