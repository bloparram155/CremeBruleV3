using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class AdminDAL
    {
        ContextModel model = new ContextModel();

        public List<Usuario> GetUsuariosList()
        {
            var usuarios = model.Usuario.ToList();
            return usuarios;
        }

        public List<Producto> listaProductos()
        {
            var productos = model.Producto.ToList();
            return productos;
        }

        public bool AgregarProducto(Producto producto)
        {
            bool status = false;
            model.Producto.Add(producto);
            model.SaveChanges();
            return status;
        }

        public List<Usuario> BuscarUsuarioNombre(Usuario user)
        {
            var lista = from k in model.Usuario where k.Nombre.Contains(user.Nombre) select k;
            List<Usuario> listaUsuario = new List<Usuario>();
            foreach (var item in lista)
            {
                Usuario us = new Usuario();
                us.UsuarioID = user.UsuarioID;
                us.Nombre = user.Nombre;
                us.Email = user.Email;
                us.TipoUsuario = user.TipoUsuario;
                us.CuentaVerificada = user.CuentaVerificada;
                listaUsuario.Add(us);
            }
            return listaUsuario;
        }
    }
}
