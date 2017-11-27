using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ProductoDAL
    {
        ContextModel model = new ContextModel();
        public List<Producto> listProducto()
        {
            var lista = model.Producto.ToList();
            return lista;
        }

        public List<Producto> BuscarProductoNombre(Producto producto)
        {
            var lista = from k in model.Producto where k.Nombre.Contains(producto.Nombre) select k;
            List<Producto> listaProducto = new List<Producto>();
            foreach (var item in lista)
            {
                Producto pro = new Producto();
                pro.ProductoID = item.ProductoID;
                pro.Nombre = item.Nombre;
                pro.Categoria = item.Categoria;
                pro.Presentacion = item.Presentacion;
                pro.Cantidad = item.Cantidad;
                pro.Precio = item.Precio;
                listaProducto.Add(pro);
            }
            return listaProducto;
        }
    }
}
