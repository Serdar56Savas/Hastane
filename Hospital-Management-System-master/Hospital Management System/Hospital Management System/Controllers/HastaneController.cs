using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital_Management_System.CollectionViewModels;
using Hospital_Management_System.Models;
using Microsoft.AspNet.Identity;

namespace Hospital_Management_System.Controllers
{

    public class HastaneController : Controller
    {
        // GET: Hastane
        private ApplicationDbContext db;

        public HastaneController()
        {
            db = new ApplicationDbContext();
        }

        //Constructor


        //Destructor
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Departmans()
        {


            return View();
        }

        public ActionResult Contact()
        {


            return View();
        }
        public ActionResult Doctor()
        {
            var model = new CollectionOfAll
            {
                Doctors = db.Doctors.ToList()
            };
            return View(model);
        }
        public ActionResult Blog()
        {


            return View();
        }

    }
}