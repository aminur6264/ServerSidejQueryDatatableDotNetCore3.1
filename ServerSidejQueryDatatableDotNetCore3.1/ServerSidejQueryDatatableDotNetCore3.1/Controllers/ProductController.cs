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
        public IActionResult NewProduct(int? id)
        {
            Product product = new Product();
            if (id != null)
                product = db.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult NewProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                //Product product = new Product();
                if (product.Id != 0)
                {
                    var existProduct = db.Products.FirstOrDefault(x => x.Id == product.Id);
                    existProduct.Name = product.Name;
                    existProduct.Brand = product.Brand;
                    existProduct.Model = product.Model;
                    existProduct.Size = product.Size;
                    existProduct.Price = product.Price;
                    db.Products.Update(existProduct);
                }
                else
                    db.Products.Add(product);

                db.SaveChanges();
                return RedirectToAction("Index","Product");
            }
            else
                return View(product);
        }

        [HttpPost]
        public IActionResult AllProduct([FromBody] DtParameters dtParameters)
        {
            string productName = dtParameters.Columns[1].Search.Value.ToString();
            string productBrand = dtParameters.Columns[2].Search.Value.ToString();

            string productModel = dtParameters.Columns[3].Search.Value.ToString();
            string productSize = dtParameters.Columns[4].Search.Value.ToString();

            string productPrice = dtParameters.Columns[5].Search.Value.ToString();




            List<Product> products = db.Products.ToList();
            int totalResultsCount = products.Count;
            if (productName != "")
                products = products.Where(x => x.Name.ToLower().Contains(productName.ToLower())).ToList();
            if (productBrand != "")
                products = products.Where(x => x.Brand.ToLower().Contains(productBrand.ToLower())).ToList();
            if (productModel != "")
                products = products.Where(x => x.Model.ToLower().Contains(productModel.ToLower())).ToList();
            if (productSize != "")
                products = products.Where(x => x.Size.ToLower().Contains(productSize.ToLower())).ToList();
            if (productPrice != "")
                products = products.Where(x => x.Price.ToString().ToLower().Contains(productPrice.ToLower())).ToList();


            #region Order By
            var orderCriteria = string.Empty;
            string orderByDir = dtParameters.Order[0].Dir.ToString().ToLower();
            if (dtParameters.Order != null)
            {
                switch (dtParameters.Order[0].Column)
                {
                    case 1:
                        if (orderByDir.ToLower() == "asc")
                            products = products.OrderBy(x => x.Name).ToList();
                        else
                            products = products.OrderByDescending(x => x.Name).ToList();
                        break;
                    case 2:
                        if (orderByDir.ToLower() == "asc")
                            products = products.OrderBy(x => x.Brand).ToList();
                        else
                            products = products.OrderByDescending(x => x.Brand).ToList();
                        break;
                    case 3:
                        if (orderByDir.ToLower() == "asc")
                            products = products.OrderBy(x => x.Model).ToList();
                        else
                            products = products.OrderByDescending(x => x.Model).ToList();
                        break;
                    case 4:
                        if (orderByDir.ToLower() == "asc")
                            products = products.OrderBy(x => x.Size).ToList();
                        else
                            products = products.OrderByDescending(x => x.Size).ToList();
                        break;
                    case 5:
                        if (orderByDir.ToLower() == "asc")
                            products = products.OrderBy(x => x.Price).ToList();
                        else
                            products = products.OrderByDescending(x => x.Price).ToList();
                        break;
                        //case 6:
                        //    if (orderByDir.ToLower() == "asc")
                        //        products = products.OrderBy(x => x.Id).ToList();
                        //    else
                        //        products = products.OrderByDescending(x => x.Id).ToList();
                        //    break;
                        //default:
                        //    if (orderByDir.ToLower() == "asc")
                        //        products = products.OrderBy(x => x.Id).ToList();
                        //    else
                        //        products = products.OrderByDescending(x => x.Id).ToList();
                        //    break;
                }
            }
            #endregion

            int filteredResultsCount = products.Count;
            var result = products.Skip(dtParameters.Start).Take(dtParameters.Length).Select((x, index) => new
            {
                SL = index + 1,
                Id = x.Id,
                Name = x.Name,
                Brand = x.Brand,
                Model = x.Model,
                Size = x.Size,
                Price = x.Price
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
