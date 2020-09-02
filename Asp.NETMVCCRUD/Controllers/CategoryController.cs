using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NETMVCCRUD.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult AddorEdit(int id = 0)
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddorEdit()
        {
            return View();
        }
    }
}