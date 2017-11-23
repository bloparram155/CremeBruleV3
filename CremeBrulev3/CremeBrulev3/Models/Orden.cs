using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CremeBrulev3.Models
{
    public class Orden
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdenID { get; set; }
        public int CuentaID { get; set; }
        public int CarritoID { get; set; }
        public DateTime FechaOrden { get; set; }

        //navprops      
        [ForeignKey("CuentaID")]
        public Cuenta cuenta { get; set; }
        [ForeignKey("CarritoID")]
        public Carrito carrito { get; set; }

    }
}