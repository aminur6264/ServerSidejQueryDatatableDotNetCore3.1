using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServerSidejQueryDatatableDotNetCore3._1.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewSale()
        {
            return View();
        }
    }
}
