using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bakery2018.Models;

namespace Bakery2018.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            BakeryEntities db = new BakeryEntities();
            return View(db.Products.ToList());
        }
    }
}