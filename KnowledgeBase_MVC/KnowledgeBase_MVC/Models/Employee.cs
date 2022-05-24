using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase_MVC.Models
{
    public class Employee
    {
        [Key]
        public string NumberEmployee { get; set; }

        [Required]
        [MaxLength(100)]
        public string FIO { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

    }
}
