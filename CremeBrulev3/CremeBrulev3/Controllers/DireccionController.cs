using CremeBrulev3.Context;
using CremeBrulev3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CremeBrulev3.Controllers
{
    public class DireccionController : Controller
    {
        ContextModel context = new ContextModel();
        // GET: Direccion
        public ActionResult Direccion()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Direccion(string coloniaTxt,string calleTxt,string estadoTxt,string ciudadTxt,int codigoPostalTxt)
        {
            try
            {

                Direccion dir = new Models.Direccion();
                dir.UsuarioID = Int32.Parse(Session["UsuarioID"].ToString());
                dir.Colonia = coloniaTxt;
                dir.Calle = calleTxt;
                dir.Estado = estadoTxt;
                dir.Ciudad = ciudadTxt;
                dir.CodigoPostal = codigoPostalTxt;
                context.Direccion.Add(dir);
                context.SaveChanges();
                ViewBag.Message= "Dirección registrada.";
            }catch(Exception e)
            {

            }
            
           
            return View();
        }
        
    }
}
