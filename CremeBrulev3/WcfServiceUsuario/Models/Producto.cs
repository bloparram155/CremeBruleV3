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
    public class Producto
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        [DataMember]
        [Required]
        public string Nombre { get; set; }
        [DataMember]
        [Required]
        public string Categoria { get; set; }
        [DataMember]
        [Required]
        public string Presentacion { get; set; }
        [DataMember]
        [Required]
        public int CodigoProducto { get; set; }
        [DataMember]
        [Required]
        public int Cantidad { get; set; }
        [DataMember]
        [Required]
        public decimal Precio { get; set; }
        

    }
}