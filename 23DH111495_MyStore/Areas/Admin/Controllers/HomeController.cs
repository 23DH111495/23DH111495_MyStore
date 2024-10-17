using _23DH111495_MyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23DH111495_MyStore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public class ProductSearchVM
        {
            public IEnumerable<Product> Products { get; set; }
            // Other properties related to the search
        }
    }
}