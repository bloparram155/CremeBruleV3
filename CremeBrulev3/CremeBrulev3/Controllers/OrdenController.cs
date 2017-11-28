using BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CremeBrulev3.Controllers
{
    public class OrdenController : Controller
    {
        // GET: Orden
        UsuarioLogic userLogic = new UsuarioLogic();

        public ActionResult MisOrdenes()
        {
            return View(userLogic.ObtenerOrdenesUsuario());
        }

    }
}
