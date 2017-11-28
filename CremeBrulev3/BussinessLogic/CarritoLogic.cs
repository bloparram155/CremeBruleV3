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
    }
}
