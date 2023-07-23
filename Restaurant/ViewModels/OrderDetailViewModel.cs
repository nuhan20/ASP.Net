using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Restaurant.ViewModels
{
    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }
        public int ItemId { get; set; }
        [Required]
        [Display(Name ="Quantity")]
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }

        [Required]
        [Display (Name = "Give some Discount")]
        public decimal Discount { get; set; }

        [Required]
        [Display (Name ="Unit Price")]
        public decimal UnitPrice { get; set; }

    }
}