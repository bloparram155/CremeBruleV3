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
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
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
                Usuario user = context.Usuario.Single(x => x.Email == emailTxt && x.Password == passwordTxt );
                if (user != null)
                {
                    Session["UsuarioID"] = user.UsuarioID.ToString();
                    Session["Nombre"] = user.Nombre.ToString();
                    Session["Email"] = user.Email.ToString();
                    Session["Password"] = user.Password.ToString();
                    Session["TipoUsuario"] = user.TipoUsuario.ToString();
                    return RedirectToAction("Index");

                }
                else
                {
                    ModelState.AddModelError("", "Nombre de Usuario o Password Incorrectos.");
                }
            }
            catch (Exception)
            {
              
            }
            
             return View();
        }

     
        public ActionResult LoginInfo()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult LoginInfo(string nombreTxt)
        {

            return View();
        }


        //Controlador para Editar al usuario
        public ActionResult Editar()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            return View();
        }

        [HttpPost]  
        public ActionResult Editar(string nombreTxt)
        {
            try
            {
                Usuario user = new Usuario();
                user.Nombre = nombreTxt;
                context.Entry(user).State = EntityState.Modified;
                ViewBag.Message("Nombre usuario"+user.Nombre+"Editado.");
            }catch(Exception e)
            {

            }
            
            return RedirectToAction("Perfil");
        }


        //Controlador para Registrar Usuarios
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(string nombreTxt,string emailTxt,string passwordTxt)
        {
            try
            {
                Usuario user = new Usuario();
                user.Nombre = nombreTxt;
                user.Email = emailTxt;
                user.Password = passwordTxt;
                
                context.Usuario.Add(user);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            return RedirectToAction("LoginInfo");
        }





        public ActionResult Perfil()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            return View();
        }

        public ActionResult Eliminar()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
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

    }
}