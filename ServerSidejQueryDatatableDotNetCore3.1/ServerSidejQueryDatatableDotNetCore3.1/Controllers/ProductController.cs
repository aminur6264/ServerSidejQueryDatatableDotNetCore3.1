using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerSidejQueryDatatableDotNetCore3._1.Models;
using ServerSidejQueryDatatableDotNetCore3._1.Utility;

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

        [HttpPost]
        public IActionResult AllProduct([FromBody] DtParameters dtParameters)
        {
            string productName = dtParameters.Columns[1].Search.Value.ToString();
            string productBrand = dtParameters.Columns[2].Search.Value.ToString();

            string productModel = dtParameters.Columns[3].Search.Value.ToString();
            string productSize = dtParameters.Columns[4].Search.Value.ToString();

            string productPrice = dtParameters.Columns[5].Search.Value.ToString();


            #region Order By
            var orderCriteria = string.Empty;
            string orderByDir = "";
            if (dtParameters.Order != null)
            {
                switch (dtParameters.Order[0].Column)
                {
                    case 1:
                        orderCriteria = "BND.Id";
                        break;
                    case 2:
                        orderCriteria = "BND.Name";
                        break;
                    case 3:
                        orderCriteria = "CTG.Id";
                        break;
                    case 4:
                        orderCriteria = "CTG.Name";
                        break;
                    case 5:
                        orderCriteria = "TYP.Id";
                        break;
                    case 6:
                        orderCriteria = "TYP.Name";
                        break;
                    default:
                        orderCriteria = "Id";
                        break;
                }

                orderByDir = dtParameters.Order[0].Dir.ToString().ToLower();
            }
            else
            {
                orderCriteria = "CTG.Id";
            }
            string orderBy = " ORDER BY " + orderCriteria + " " + orderByDir;
            #endregion

            List<Product> products = db.Products.ToList();
            if (productName != "")
                products = products.Where(x => x.Name.ToLower().Contains(productName.ToLower())).ToList();
            if(productBrand != "")
                products = products.Where(x => x.Brand.ToLower().Contains(productBrand.ToLower())).ToList();
            if (productModel != "")
                products = products.Where(x => x.Model.ToLower().Contains(productModel.ToLower())).ToList();
            if (productSize != "")
                products = products.Where(x => x.Size.ToLower().Contains(productSize.ToLower())).ToList();


            var result = products.Select((x, index) => new
            {
                SL = index + 1,
                Id = x.Id,
                Name = x.Name,
                Brand = x.Brand,
                Model = x.Model,
                Size = x.Size,
                Price = x.Price
            }).ToList();

            return Json(new { data = result });
        }
    }
}
