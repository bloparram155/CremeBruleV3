using BussinessLogic;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CremeBrulev3.Controllers
{
    public class CarritoController : Controller
    {
        ProductoLogic prodLogic = new ProductoLogic();
        CarritoLogic cartLogic = new CarritoLogic();
        // GET: Carrito
        public ActionResult MiCarrito()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            if (Session["Carrito"] == null)
            {
                return Redirect("/Producto/Index/");
            }

            Carrito carrito = Session["Carrito"] as Carrito;

            return View(carrito.productoLista);
        }

        /*public ActionResult AgregarCarrito()
        {
           Carrito carrito = SessionStateAttribute[]
        }
        */

        public ActionResult AddCarrito(int ProductoID, int cantidad)
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            Carrito carrito = Session["Carrito"] as Carrito;
            if (carrito == null || Session["Carrito"] == null)
            {
                carrito = new Carrito();
                Session["Carrito"] = carrito;
            }
            var producto = prodLogic.BusquedaProductoSolo(ProductoID);
            producto.Cantidad = cantidad;
            carrito.productoLista.Add(producto);
            carrito.SubTotal = cartLogic.ObtenerSubTotal(carrito.productoLista);
            carrito.Total = cartLogic.ObtenerTotal(carrito.productoLista);
            Session["CarritoTotal"] = carrito.Total;
            Session["CarritoSub"] = carrito.SubTotal;
            return RedirectToAction("MiCarrito");
        }

        /*[HttpPost]
        public ActionResult ActualizarCantidadItemCarrito(int cantidadTxt)
        {
            Carrito carrito = Session["Carrito"] as Carrito;
            if (carrito == null || Session["Carrito"] == null)
            {
                carrito = new Carrito();
                Session["Carrito"] = carrito;
            }

            foreach (var item in carrito.productoLista) {
                Producto producto = item;
                producto.Cantidad = cantidadTxt;
                        }

            return RedirectToAction("Micarrito");
        }*/
      
       public ActionResult RealizarCompra()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            Carrito carrito = Session["Carrito"] as Carrito;
            Session["CarritoID"] = carrito.CarritoID;
            int cartID = Int32.Parse(Session["CarritoID"].ToString());
            int userID = Int32.Parse(Session["UsuarioID"].ToString());
            bool status = cartLogic.RealizarCompra(carrito,userID,cartID);
            Session.Remove("Carrito");
            return Redirect("/Home/Index/");
            
        }

       
    }
}