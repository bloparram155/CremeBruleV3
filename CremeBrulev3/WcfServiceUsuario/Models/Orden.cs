using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WcfServiceUsuario.Models
{
    [DataContract]
    public class Orden
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdenID { get; set; }
        [DataMember]
        [ForeignKey("usuario")]
        public int UsuarioID { get; set; }
        [DataMember]
        [ForeignKey("carrito")]
        public int CarritoID { get; set; }
        [DataMember]
        public DateTime FechaOrden { get; set; }

        //navprops  
        [DataMember]
        public Usuario usuario { get; set; }
        [DataMember]
        public Carrito carrito { get; set; }

    }
}