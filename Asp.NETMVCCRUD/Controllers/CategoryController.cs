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
             emp = new Ticket();
            using (BugDBEntities db = new BugDBEntities()) 
            {
                emp.CategoryCollection = db.Categories.ToList();
            }
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddorEdit(Ticket emp)
        {
            using (BugDBEntities db = new BugDBEntities())
            {
                db.SelectedCategories.Add(emp);
                db.SaveChanges();
            }
            return RedirectToAction("Employee", new { id = 0 });
        }
    }
}