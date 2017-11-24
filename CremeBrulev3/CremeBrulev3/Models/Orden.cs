using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CremeBrulev3.Models
{
    
    public class Orden
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdenID { get; set; }
        [ForeignKey("usuario")]
        public int UsuarioID { get; set; }
        [ForeignKey("carrito")]
        public int CarritoID { get; set; }
        [DataMember]
        public DateTime FechaOrden { get; set; }

        //navprops  
        
        public Usuario usuario { get; set; }
        public Carrito carrito { get; set; }

    }
}