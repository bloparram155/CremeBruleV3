using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class UsuarioDAL
    {
        ContextModel model = new ContextModel();

        public List<Usuario> GetUsuariosList()
        {
            var usuarios = model.Usuario.ToList();
            return usuarios;
        }

        public Usuario Login(string email, string password)
        {

            Usuario user = model.Usuario.Single(x => x.Email == email && x.Password == password);
            return user;   
        }

        public bool EditarNombre(Usuario user)
        {
            bool status = false;
            
                model.Entry(user).State = EntityState.Modified;
                model.SaveChanges();
                status = true;

            
            return status;
        }

        public bool EditarEmail(Usuario user)
        {
            bool status = false;
            model.Entry(user).State = EntityState.Modified;
            model.SaveChanges();
            status = true;
            return status;
        }

        public bool EditarPassword(Usuario user)
        {
            bool status = false;
            model.Entry(user).State = EntityState.Modified;
            model.SaveChanges();
            status = true;
            return status;
        }

        public bool RegistrarUsuario(Usuario user)
        {
            bool status = false;
            model.Usuario.Add(user);
            model.SaveChanges();
            return status;
        }

        public bool EliminarUsuario(Usuario user)
        {
            bool status = false;
            model.Entry(user).State = EntityState.Deleted;
            model.SaveChanges();
            status = true;
            return status;

        }

        public List<Orden> ObtenerOrdenesUsuario()
        {
            var ordenes = model.Orden.Include(x => x.carrito).Include(y => y.usuario).ToList();
            return ordenes;
        }
    }
}
