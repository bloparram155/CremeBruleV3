
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{

    public class CarritoDAL
    {
        ContextModel model = new ContextModel();

        public bool AgregarCarrito(Carrito carrito)
        {
            model.Carrito.Add(carrito);
            model.SaveChanges();
            
            return true;
        }

        public bool AgregarOrden(Orden orden)
        {
            model.Orden.Add(orden);
            model.SaveChanges();
            return true;
        }

        public Carrito ObtenerUltimoCarrito()
        {
            var carrito = model.Carrito.ToList().LastOrDefault();
            return carrito;
        }

       


    }
}
