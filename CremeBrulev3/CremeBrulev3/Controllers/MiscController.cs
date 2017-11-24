using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CremeBrulev3.Controllers
{
    public class MiscController : Controller
    {
        // GET: Nosotros
        public ActionResult Nosotros()
        {
            return View();
        }

        public ActionResult Sucursales()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }
    }
}