using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Restaurant.ViewModels
{
    public class PaymentTypeViewModel
    {
        public int PaymentTypeId { get; set; }
        [Required]
        [Display(Name ="Type Name")]
        public string PaymentTypeName { get; set; }
    }
}