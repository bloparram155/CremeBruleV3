using CremeBrulev3.Context;
using CremeBrulev3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CremeBrulev3.Controllers
{
    public class UsuarioController : Controller
    {
        ContextModel context = new ContextModel();
        ServicioUsuario.ServiceUsuarioClient servu = new ServicioUsuario.ServiceUsuarioClient();
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string emailTxt, string passwordTxt)
        {
            try
            {
                bool status=servu.LoginUser(emailTxt,passwordTxt);
                if (status == true)
                {
                    return View();

                }
                    


            }
            catch (Exception)
            {
              
            }
            
            
            return View();
        }


        public ActionResult Eliminar()
        {
            
            return View();
        }
        
        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {
                
               bool status = false;
               Usuario user = new Usuario();
               user.UsuarioID = id;
               context.Entry(user).State = EntityState.Deleted;
                
               

            }
            catch (Exception)
            {

            }
            return View();
        }

        public ActionResult LoginInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginInfo(string nombreTxt)
        {

            return View();
        }


        public ActionResult Direcciones()
        {

            return View();
        }


        public ActionResult Registro()
        {
            return View();
        }

        public ActionResult Perfil()
        {
            return View();
        }
       
    }
}