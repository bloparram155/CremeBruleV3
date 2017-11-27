using BussinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CremeBrulev3.Controllers
{
    public class indexAdminController : Controller
    {

        AdminLogic adminLogic = new AdminLogic();
        ProductoLogic prodLogic = new ProductoLogic();
        // GET: indexAdmin

        public ActionResult Index()
        {
            if(Session["UsuarioID"] == null)
            {
               
                return Redirect("/Usuario/Login/");
            }
            else
            {
                if(Session["TipoUsuario"].ToString() != "ADMIN")
                {
                    return Redirect("/Home/Index/");
                }
            }
            return View();
        }

        public ActionResult Productos()
        {
            if (Session["UsuarioID"] == null)
            {

                return Redirect("/Usuario/Login/");
            }
            else
            {
                if (Session["TipoUsuario"].ToString() != "ADMIN")
                {
                    return Redirect("/Home/Index/");
                }
            }
            return View();
        }

        public ActionResult Clientes()
        {
            if (Session["UsuarioID"] == null)
            {

                return Redirect("/Usuario/Login/");
            }
            else
            {
                if (Session["TipoUsuario"].ToString() != "ADMIN")
                {
                    return Redirect("/Home/Index/");
                }
            }
            return View(adminLogic.UsuarioLista());
        }

        [HttpPost]
        public ActionResult Clientes(string buscarClientes)
        {
            return View(adminLogic.ObtenerUsuariosNombre(buscarClientes));
        }

        public ActionResult Ventas()
        {
            if (Session["UsuarioID"] == null)
            {

                return Redirect("/Usuario/Login/");
            }
            else
            {
                if (Session["TipoUsuario"].ToString() != "ADMIN")
                {
                    return Redirect("/Home/Index/");
                }
            }
            return View();
        }

        public ActionResult BuscaProductos()
        {
            if (Session["UsuarioID"] == null)
            {

                return Redirect("/Usuario/Login/");
            }
            else
            {
                if (Session["TipoUsuario"].ToString() != "ADMIN")
                {
                    return Redirect("/Home/Index/");
                }
            }
            return View(adminLogic.ObtenerTodoProductos());
        }

        [HttpPost]
        public ActionResult BuscaProductos(string buscarProducto)
        {
            return View(prodLogic.BusquedaListaProducto(buscarProducto));
        }

        public ActionResult AgregarProducto()
        {
            if (Session["UsuarioID"] == null)
            {

                return Redirect("/Usuario/Login/");
            }
            else
            {
                if (Session["TipoUsuario"].ToString() != "ADMIN")
                {
                    return Redirect("/Home/Index/");
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult AgregarProducto(string nombreProductoTxt,string categoriaProductoTxt, string presentacionProductoTxt, int CantidadProductoTxt, decimal PrecioProductoTxt)
        {
            try
            {
                adminLogic.AgregarProducto(nombreProductoTxt, categoriaProductoTxt,presentacionProductoTxt,CantidadProductoTxt,PrecioProductoTxt);
            }catch(Exception e)
            {

            }
            return View();
        }
    }
}