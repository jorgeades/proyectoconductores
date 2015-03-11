using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coches.Models;

namespace Coches.Controllers
{
    public class ConductorController : Controller
    {

        public VehiculosEntities db = new VehiculosEntities();

        // GET: Conductor
        public ActionResult DetallesActionResult()
        {

            return View(db.Conductor.ToList());
        }
    }
}