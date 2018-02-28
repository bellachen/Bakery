using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bakery2018.Models;

namespace Bakery2018.Controllers
{
    public class SaleController : Controller
    {
        BakeryEntities db = new BakeryEntities();
        // GET: Sale
        public ActionResult Index()
        {
            return View(db.Sales.ToList());
        }

        // GET: SaleDetail
        public ActionResult Details(int? id)
        {
            var a = from s in db.SaleDetails where s.SaleKey == id select s;
           
            return View(a.ToList());
        }

    }
}

