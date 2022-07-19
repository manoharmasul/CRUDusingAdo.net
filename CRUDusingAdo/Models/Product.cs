using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDusingAdo.Models
{
    //BO business object /business class
    [Table("Product")]
    public class Product//model class or poco class(plain old c#/clr object)
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Product Name is Required")]
        [Display(Name="Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Price is Required")]
        [Display(Name="Product Price")]
        [Range(minimum:1,maximum:50000)]
        public double Price { get; set; }
    }
}
