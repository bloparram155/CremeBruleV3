using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace DataAccessLayer.Models
{
    
    public class Producto
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public string Presentacion { get; set; }
        [Required]
        public int CodigoProducto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Precio { get; set; }
        

    }
}