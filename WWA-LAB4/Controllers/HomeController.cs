using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BLL;
using WWA_LAB4.Models;

namespace WWA_LAB4.Controllers
{
    public class HomeController : Controller
    {
        public Model myModel = new Model();
        // GET: Home

        public ActionResult Index()
        {
            var records = myModel.getRecords();
            return View(records);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ContactRecord c)
        {
            myModel.addRecord(c);
            return RedirectToAction("Index");
        }
        
        public ActionResult Details(int id)
        {
            return View(myModel.Details(id));
        }

        public ActionResult Delete(int id)
        {
            myModel.deleteRecord(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(myModel.Details(id));
        }

        [HttpPost]
        public ActionResult Edit(ContactRecord c)
        {
            myModel.updateRecord(c);
            return RedirectToAction("Index");
        }
    }
}