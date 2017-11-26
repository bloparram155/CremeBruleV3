﻿using BussinessLogic;
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
        UsuarioLogic userLogic = new UsuarioLogic();
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
                
                if (userLogic.Login(emailTxt, passwordTxt) != null)
                {
                    Session["UsuarioID"] = userLogic.Login(emailTxt, passwordTxt).UsuarioID.ToString();
                    Session["Nombre"] = userLogic.Login(emailTxt, passwordTxt).Nombre.ToString();
                    Session["Email"] = userLogic.Login(emailTxt, passwordTxt).Email.ToString();
                    Session["Password"] = userLogic.Login(emailTxt, passwordTxt).Password.ToString();
                    Session["TipoUsuario"] = userLogic.Login(emailTxt, passwordTxt).TipoUsuario.ToString();
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
        public ActionResult LoginInfo(int eliminarTxt)
        {
            try
            {

                /*Usuario user = new Usuario();
                user.UsuarioID = eliminarTxt;
                context.Entry(user).State = EntityState.Deleted;
                context.SaveChanges();*/
            }
            catch (Exception)
            {

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

                string email = Session["Email"].ToString();
                string password = Session["Password"].ToString();
                int id = Int32.Parse(Session["UsuarioID"].ToString());
                userLogic.EditarNombre(id, nombreTxt,email,password);
                
               
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
                
                int id = Int32.Parse(Session["UsuarioID"].ToString());
                string nombre = Session["Nombre"].ToString();   
                string password = Session["Password"].ToString();
                bool status = userLogic.EditarEmail(id,nombre,emailTxt,password);
                if(status == false)
                {
                    return RedirectToAction("Perfil");
                }
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
                int id = Int32.Parse(Session["UsuarioID"].ToString());
                string nombre = Session["Nombre"].ToString();
                string email = Session["Email"].ToString();
                bool status = userLogic.EditarPassword(id, nombre, email, passwordTxt);
               
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
                bool status = userLogic.RegistrarUsuario(nombreTxt, emailTxt, passwordTxt);
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




        

    }
}