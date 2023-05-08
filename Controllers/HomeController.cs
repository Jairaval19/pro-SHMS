using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using eMEETUP.Models;

namespace eMEETUP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Features()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Registartion()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registartion(TblUser r1)
        {
            using(SHEALTHEntities db=new SHEALTHEntities())
            {
                if(ModelState.IsValid)
                {
                    db.TblUsers.Add(r1);
                    db.SaveChanges();
                    ViewBag.message("Registartion Sucessfully");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }
        [HttpPost]
        public ActionResult Login(TblUser r1)
        {
            using (SHEALTHEntities db = new SHEALTHEntities())
            {
                if (ModelState.IsValid)
                {
                    var log = db.TblUsers.Where(a => a.userName.Equals(r1.userName) && a.password.Equals(r1.password)).FirstOrDefault();
                    if(log != null)
                    {
                        ViewBag.message("Registartion Sucessfully");
                        return RedirectToAction("Contatc");
                        
                    }
                  
                    ModelState.Clear();
                }
            }
            return View(r1);
        }
    }
}