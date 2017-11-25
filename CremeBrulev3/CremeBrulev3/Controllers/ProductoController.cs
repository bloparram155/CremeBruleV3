using CremeBrulev3.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CremeBrulev3.Controllers
{
    public class ProductoController : Controller
    {
        ContextModel context = new ContextModel();

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult AddProducto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProducto(string nombreTxt,string categoriaTxt,string presentacionTxt,int codigoProductoTxt,int cantidadTxt,decimal precioTxt)
        {
            return View();
        }
    }
}
