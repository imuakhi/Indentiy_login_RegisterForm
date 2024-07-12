using M5C11_W01.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M5C11_W01.Controllers
{
    [Authorize]
    public class TasklistController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Tasklist
        public ActionResult Index()
        {
            return View(db.TaskList.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(TaskList taskList)
        {
            try
            {
                taskList.Submitedby = User.Identity.GetUserName();
                db.TaskList.Add(taskList);
                if (db.SaveChanges() > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("",ex.Message);
            }
            return View(taskList);
        }
    }
}