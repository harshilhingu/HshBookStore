using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HshBooks.Models
{
   public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Category Name")]
        [Required]
        [MaxLength(50)]
        public string Nmae { get; set; }
        public object Name { get; set; }
    }
}
