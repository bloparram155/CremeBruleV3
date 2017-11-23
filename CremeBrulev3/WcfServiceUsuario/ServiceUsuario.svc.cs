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
        public string AddUser(Usuario usuario)
        {
            try
            {
                ContextModel context= new ContextModel();
                Usuario user = new Usuario();
                user.Nombre = usuario.Nombre;
                user.Email = usuario.Email;
                user.Password = usuario.Password;
                //user.TipoUsuario = usuario.TipoUsuario;
                //user.CuentaVerificada = usuario.CuentaVerificada;
                context.Usuario.Add(user);
                context.SaveChanges();
                return "true";
            }
            catch(Exception m)
            {
                return m.Message ;
            }
            
        }
    }
}
