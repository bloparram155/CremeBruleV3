using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CremeBrulev3.Models
{
    public class Carrito
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoID { get; set; }
        public int CuentaID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        //Properties
        [ForeignKey("CuentaID")]
        public Carrito carrito { get; set; }
        public ICollection<Producto> listProducto { get; set; }

    }
}