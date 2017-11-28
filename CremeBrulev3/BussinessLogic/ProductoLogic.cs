using DataAccessLayer.Entities;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class ProductoLogic
    {
        ProductoDAL dal = new ProductoDAL();
        public List<Producto> listProducto()
        {
            var lista = dal.listProducto();
            return lista;
        }

        public List<Producto> BusquedaListaProducto(string nombre)
        {
            Producto producto = new Producto();
            producto.Nombre = nombre;
            var lista = dal.BuscarProductoNombre(producto);
            return lista;
        }

        public Producto BusquedaProductoSolo(int id)
        {
            var producto = dal.BuscarProductoSolo(id);
            return producto;
        }

       /* public List<Producto> ActualizarCantidades(int cantidad)
        {

        }*/
    }
}
