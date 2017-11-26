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

       
        //Controlador para Editar al usuario
  

        public ActionResult EditarNombre()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            return View();
        }

        [HttpPost]  
        public ActionResult EditarNombre(string nombreTxt)
        {
            try
            {
                Usuario user = new Usuario();
                user.UsuarioID = Int32.Parse(Session["UsuarioID"].ToString());
                user.Nombre = nombreTxt;
                user.Email = Session["Email"].ToString();
                user.Password = Session["Password"].ToString();
                user.TipoUsuario = Session["TipoUsuario"].ToString();
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                ViewBag.Message("Nombre usuario"+user.Nombre+"Editado.");
            }catch(Exception e)
            {

            }
            
            return RedirectToAction("Perfil");
        }

        public ActionResult EditarEmail()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult EditarEmail(string emailTxt)
        {
            try
            {
                Usuario user = new Usuario();
                user.UsuarioID = Int32.Parse(Session["UsuarioID"].ToString());
                user.Nombre = Session["Nombre"].ToString();
                user.Email = emailTxt;
                user.Password = Session["Password"].ToString();
                user.TipoUsuario = Session["TipoUsuario"].ToString();
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Perfil");
            }catch(Exception e)
            {

            }
            return View();
           
        }


        public ActionResult EditarPassword()
        {
            if (Session["UsuarioID"] == null)
            {
                return Redirect("/Usuario/Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult EditarPassword(string passwordTxt)
        {
            try
            {
                Usuario user = new Usuario();
                user.UsuarioID = Int32.Parse(Session["UsuarioID"].ToString());
                user.Nombre = Session["Nombre"].ToString();
                user.Email = Session["Email"].ToString();
                user.Password = passwordTxt;
                user.TipoUsuario = Session["TipoUsuario"].ToString();
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Perfil");
            }
            catch (Exception e)
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
        public ActionResult LoginInfo(int eliminarTxt)
        {
            try { 
               
                Usuario user = new Usuario();
                user.UsuarioID = eliminarTxt;
                context.Entry(user).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception)
            {

            }
            return View();
        }

    }
}