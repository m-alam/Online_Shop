using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        [Display(Name="Product Color")]
        public string ProductColor { get; set; }
        [Display(Name="Available")]
        public bool IsAvailable { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductTypes { get; set; }
        public int SpecialTagId { get; set; }
        public SpecialTag SpecialTags { get; set; }
    }
}
