using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace DataAccessLayer.Models
{
    
    public class Orden
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdenID { get; set; }
        public int UsuarioID { get; set; }
        public int CarritoID { get; set; }
        public DateTime FechaOrden { get; set; }

        //navprops  
        [ForeignKey("UsuarioID")]
        public Usuario usuario { get; set; }
        [ForeignKey("CarritoID")]
        public Carrito carrito { get; set; }

    }
}