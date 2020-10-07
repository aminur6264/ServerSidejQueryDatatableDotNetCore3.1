using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerSidejQueryDatatableDotNetCore3._1.Models;

namespace ServerSidejQueryDatatableDotNetCore3._1.Controllers
{
    public class ProductController : Controller
    {
        DataTableDbContext db;
        public ProductController()
        {
            db = new DataTableDbContext(new DbContextOptions<DataTableDbContext>());
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewProduct()
        {
            return View();
        }

        public IActionResult AllProduct()
        {
            var result = db.Products.Select((x, index) => new 
            {
                SL = index + 1,
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return Json(new { data = result });
        }
    }
}
