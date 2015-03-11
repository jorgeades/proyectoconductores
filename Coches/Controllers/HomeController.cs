using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coches.Models;


namespace Coches.Controllers
{
    public class HomeController : Controller
    {

        public VehiculosEntities db = new VehiculosEntities();
        
        // GET: Home
        public ActionResult Index()
        {
 
            return View(db.Vehiculo.ToList());
        }
        public ActionResult DetallesActionResult()
        {

            return View(db.Conductor.ToList());
        }

    } 
}