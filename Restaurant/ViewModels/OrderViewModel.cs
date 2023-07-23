using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Restaurant.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int PaymentTypeId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        [Display(Name ="Order Numder")]
        public string OrderNumber { get; set; }
        [Display(Name ="Order Date")]
        public DateTime OrderDate { get { return DateTime.Now; } }
        public decimal FinalTotal { get; set; }
        public IEnumerable<OrderDetailViewModel> listOrderDetailViewModel { get; set; }

    }
}