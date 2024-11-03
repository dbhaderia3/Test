using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreViewBagViewData.Models;

namespace CoreViewBagViewData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var ptr = new Product();
            ptr.Id = 101;
            ptr.Name = "Mouse";
            ptr.Description = "Wireless";
            ptr.Price = 1021;
            ViewData["ID"] = ptr.Id;
            ViewData["Name"] = ptr.Name;
            ViewData["Description"] = ptr.Description;
            ViewData["Price"] = ptr.Price;
            return View();
        }

        public IActionResult About()
        {
            Product ptr = new Product();
            ptr.Id = 102;
            ptr.Name = "LED Screen";
            ptr.Description = "Wireless";
            ptr.Price = 102450;
            ViewBag.ptrs = ptr;
            return View();
        }

        public IActionResult Contact(Product ptr)
        {
            //Product ptr = new Product();
            ptr.Id = 102;
            ptr.Name = "LED Screen";
            ptr.Description = "Wireless";
            ptr.Price = 102450;
            ViewBag.ptrs = ptr;
            return View(ptr);
        }

        public IActionResult GetAllData()
        {

            var ProductList = new List<Product>();
            Product ptr1 = new Product();
            ptr1.Id = 101;
            ptr1.Name = "LED Screen";
            ptr1.Description = "Wireless";
            ptr1.Price = 102450;

            Product ptr2 = new Product();
            ptr2.Id = 102;
            ptr2.Name = "LED Screen";
            ptr2.Description = "Wireless";
            ptr2.Price = 102450;


            Product ptr3 = new Product();
            ptr3.Id = 103;
            ptr3.Name = "LED Screen";
            ptr3.Description = "Wireless";
            ptr3.Price = 102450;


            Product ptr4 = new Product();
            ptr4.Id = 102;
            ptr4.Name = "LED Screen";
            ptr4.Description = "Wireless";
            ptr4.Price = 102450;
            ProductList.Add(ptr1);
            ProductList.Add(ptr2);
            ProductList.Add(ptr3);
            ProductList.Add(ptr4);
            ViewBag.prt = ProductList;
                return View();
        }
    }
}
