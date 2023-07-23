using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Restaurant.ViewModels
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
        [Required]
        [Display(Name = "Item Price")]
        public decimal ItemPrice { get; set; }
    }
}