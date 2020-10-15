using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using ServerSidejQueryDatatableDotNetCore3._1.Models;
using ServerSidejQueryDatatableDotNetCore3._1.Utility;
using ServerSidejQueryDatatableDotNetCore3._1.ViewModels;

namespace ServerSidejQueryDatatableDotNetCore3._1.Controllers
{
    public class SaleController : Controller
    {
        DataTableDbContext db;
        public SaleController()
        {
            db = new DataTableDbContext(new DbContextOptions<DataTableDbContext>());
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InvoiceReport(int id)
        {
            var invoice = db.Invoices.FirstOrDefault();
            //int id = invoice.Id;
            var invoiceDetails = db.InvoiceDetails.Where(x => x.InvoiceId == id).ToList();
            List<InvoiceDetailsViewModel> GetSaleDetailsByInvoice = new List<InvoiceDetailsViewModel>();
            foreach (InvoiceDetails item in invoiceDetails)
            {
                Product product = db.Products.FirstOrDefault(x => x.Id == item.ProductId);
                InvoiceDetailsViewModel details = new InvoiceDetailsViewModel()
                {
                    Name = product.Name,
                    ProductId = product.Id,
                    Brand = product.Brand,
                    Model = product.Model,
                    Size = product.Size,
                    InvoiceId = id,
                    Discount = item.Discount,
                    SalePrice = item.SalePrice
                };
                GetSaleDetailsByInvoice.Add(details);
            }
            ReportViewModel invoiceViewModel = new ReportViewModel()
            {
                InvoiceNo = id,
                InvoiceDetails = GetSaleDetailsByInvoice,
                TotalDiscount = invoice.DiscountAmount,
                TotalPrice = invoice.TotalAmount
            };
            //return Json(invoiceViewModel);
            return new ViewAsPdf(invoiceViewModel);
            //return View(invoiceViewModel);
        }
        public IActionResult NewSale()
        {
            InvoiceViewModel invoice = new InvoiceViewModel();
            return View(invoice);
        }
        public IActionResult GetSaleDetailsByInvoice(int id)
        {
            var invoice = db.Invoices.FirstOrDefault(x => x.Id == id);
            var invoiceDetails = db.InvoiceDetails.Where(x => x.InvoiceId == id).ToList();
            List<InvoiceDetailsViewModel> GetSaleDetailsByInvoice = new List<InvoiceDetailsViewModel>();
            foreach (InvoiceDetails item in invoiceDetails)
            {
                Product product = db.Products.FirstOrDefault(x=>x.Id == item.ProductId);
                InvoiceDetailsViewModel details = new InvoiceDetailsViewModel()
                {
                    Name = product.Name,
                    ProductId = product.Id,
                    Brand  = product.Brand,
                    Model  = product.Model,
                    Size  = product.Size,
                    InvoiceId = id,
                    Discount = item.Discount,
                    SalePrice = item.SalePrice
                };
                GetSaleDetailsByInvoice.Add(details);
            }
            ReportViewModel invoiceViewModel = new ReportViewModel()
            {
                InvoiceNo = id,
                InvoiceDetails = GetSaleDetailsByInvoice,
                TotalDiscount = invoice.DiscountAmount,
                TotalPrice = invoice.TotalAmount
            };
            return Json(invoiceViewModel);
        }
        [HttpPost]
        public IActionResult NewSale(InvoiceViewModel invoices)
        {
            Invoice invoice = new Invoice()
            {
                SalesDate = DateTime.Now,
                DiscountAmount = invoices.TotalDiscount,
                TotalAmount = invoices.TotalPrice
            };
            db.Invoices.Add(invoice);
            db.SaveChanges();
            foreach (var item in invoices.InvoiceDetails)
            {
                InvoiceDetails invoiceDetails = new InvoiceDetails()
                {
                    InvoiceId = invoice.Id,
                    ProductId = item.ProductId,
                    SalePrice = item.SalePrice,
                    Discount = item.Discount
                };
                db.InvoiceDetails.Add(invoiceDetails);
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Sale");
        }

        public IActionResult AllSales([FromBody] DtParameters dtParameters)
        {
            int totalResultsCount = 0;
            int filteredResultsCount = 0;

            var invoices = db.Invoices.ToList();


            var result = invoices.Select((x, index) => new
            {
                SL = index + 1,
                Id = x.Id,
                SalesDate = x.SalesDate.ToString("dd/MMM/yyyy"),
                DiscountAmount = x.DiscountAmount,
                TotalAmount = x.TotalAmount
            }).ToList();

            return Json(new
            {
                draw = dtParameters.Draw,
                recordsTotal = totalResultsCount,
                recordsFiltered = filteredResultsCount,
                data = result
            });
        }
    }
}
