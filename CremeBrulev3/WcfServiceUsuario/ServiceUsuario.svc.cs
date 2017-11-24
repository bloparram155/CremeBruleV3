using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceUsuario.Context;
using WcfServiceUsuario.Models;

namespace WcfServiceUsuario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServiceUsuario
    {
        public bool AddUser(string nombre,string email,string password)
        {
            try
            {
                ContextModel context= new ContextModel();
                Usuario user = new Usuario();
                user.Nombre = nombre;
                user.Email = email;
                user.Password = password;
                //user.TipoUsuario = usuario.TipoUsuario;
                //user.CuentaVerificada = usuario.CuentaVerificada;
                context.Usuario.Add(user);
                context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        public bool LoginUser(string email,string password)
        {
            bool status = false;
            try
            {
                ContextModel db = new ContextModel();
                Usuario user = db.Usuario.Where(x => x.Email == email).FirstOrDefault();
                if (user != null)
                {
                    if(user.Password == password)
                    {
                       status= true;
                    }
                }
                else
                {
                   status =false;
                }
            }
            catch (Exception )
            {
                return false; 
            }

            return status;
        }

        public Usuario SessionUser(string email)
        {
            bool status = false;
            ContextModel db = new ContextModel();
            Usuario user = db.Usuario.Where(x => x.Email == email).FirstOrDefault();
            return user;
        }
    }
}
