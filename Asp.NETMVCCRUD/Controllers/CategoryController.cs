using Asp.NETMVCCRUD.Models;
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
            SelectedCategory emp = new SelectedCategory();
            using (BugModel db = new BugModel()) 
            {
                emp.CategoryCollection = db.Categories.ToList();
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddorEdit(SelectedCategory emp)
        {
            using (BugModel db = new BugModel())
            {
                db.SelectedCategories.Add(emp);
                db.SaveChanges();
            }
            return RedirectToAction("Employee", new { id = 0 });
        }
    }
}