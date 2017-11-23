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
    public class Carrito
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoID { get; set; }
        [DataMember]
        public int UsuarioID { get; set; }
        [DataMember]
        public decimal SubTotal { get; set; }
        [DataMember]
        public decimal Total { get; set; }

        //Properties
        [DataMember]
        [ForeignKey("UsuarioID")]
        public Usuario usuario { get; set; }
        [DataMember]
        public ICollection<Producto> listProducto { get; set; }

    }
}