using DataAccessLayer.Entities;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class CarritoLogic
    {
        CarritoDAL cartDal = new CarritoDAL();
        public decimal ObtenerSubTotal(List<Producto> producto)
        {
            decimal subtotal=0;
            foreach(var item in producto)
            {
                decimal precio = item.Cantidad * item.Precio;
                subtotal = precio + subtotal;
            }

            return subtotal;
        }

        public decimal ObtenerTotal(List<Producto> producto)
        {
            decimal total = 0;
            foreach (var item in producto)
            {
                decimal precio = item.Cantidad * item.Precio;
                total = precio + total;
            }

            return total;
        }

        public bool RealizarCompra(Carrito carrito, int usuarioId, int carritoId)
        {
            carrito.UsuarioID = usuarioId;
            cartDal.AgregarCarrito(carrito);
            var cart= cartDal.ObtenerUltimoCarrito();
            Orden orden = new Orden();
            orden.UsuarioID = usuarioId;
            orden.CarritoID = cart.CarritoID;
            orden.FechaOrden = DateTime.Now;
            cartDal.AgregarOrden(orden);
            return true;
        }
    }
}
