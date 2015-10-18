namespace Shop.Areas.Shop.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(100, MinimumLength=10)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Category { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime? CreatedOn { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime? LastModifiedOn { get; set; }
    }
}