using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WWA_LAB4.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        [Route("Error/Index/{id}")]
        public ActionResult Index(int id)
        {
            ViewBag.currentError = id;
            return View(id);
        }
    }
}