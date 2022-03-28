using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayout.Models
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Bu hisseni bos buraxmayin")]
        [StringLength(20, ErrorMessage = "Uzunluq cox ola bilmez")]
        public string Name { get; set; }
        [NotMapped]
        public object Categories { get; internal set; }
    } 
    
}
