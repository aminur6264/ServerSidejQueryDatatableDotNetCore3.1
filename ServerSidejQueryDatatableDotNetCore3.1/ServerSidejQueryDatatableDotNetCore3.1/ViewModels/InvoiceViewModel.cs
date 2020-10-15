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
    public class ReportViewModel
    {
        public int InvoiceNo { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public List<InvoiceDetailsViewModel> InvoiceDetails { get; set; }
    }
    public class InvoiceDetailsViewModel
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Discount { get; set; }
    }

}
