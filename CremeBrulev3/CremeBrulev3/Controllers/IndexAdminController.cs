using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CremeBrulev3.Controllers
{
    public class indexAdminController : Controller
    {
        // GET: indexAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Productos()
        {
            return View();
        }

        public ActionResult Clientes()
        {
            return View();
        }

        public ActionResult Ventas()
        {
            return View();
        }

        public ActionResult BuscaProductos()
        {
            return View();
        }

        public ActionResult AgregarProducto()
        {
            return View();
        }
    }
}