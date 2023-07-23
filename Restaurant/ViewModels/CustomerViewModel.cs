using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Restaurant.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Please do not enter values over 15 characters")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

    }
}