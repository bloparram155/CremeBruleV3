using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace BussinessLogic
{
    public class AdminLogic
    {

        AdminDAL dal = new AdminDAL();

        public List<Usuario> UsuarioLista()
        {
            var listUsuario = dal.GetUsuariosList();
            return listUsuario;
        }

        public List<Producto> ObtenerTodoProductos()
        {
            var productos = dal.listaProductos();
            return productos;
        }

        public bool AgregarProducto(string nombre, string categoria, string presentacion, int cantidad, decimal precio)
        {
            Producto producto = new Producto();
            producto.Nombre = nombre;
            producto.Categoria = categoria;
            producto.Presentacion = presentacion;
            producto.Cantidad = cantidad;
            producto.Precio = precio;
            bool status = dal.AgregarProducto(producto);
            return status;
        }

        public List<Usuario> ObtenerUsuariosNombre(string nombre)
        {
            Usuario user = new Usuario();
            user.Nombre = nombre;
            var usuarios = dal.BuscarUsuarioNombre(user);
            return usuarios;
        }
    }

}
