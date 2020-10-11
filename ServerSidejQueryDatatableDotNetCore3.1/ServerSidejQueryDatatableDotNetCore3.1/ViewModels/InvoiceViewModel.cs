using ServerSidejQueryDatatableDotNetCore3._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSidejQueryDatatableDotNetCore3._1.ViewModels
{
    public class InvoiceViewModel
    {
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public List<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
