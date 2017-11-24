using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CremeBrulev3.Models
{
    
    public class Direccion
    {
      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionID { get; set; }
        public int UsuarioID { get; set; }
        [Required]
        public string Colonia { get; set; }
        [Required]
        public string Calle { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public int CodigoPostal { get; set; }


        //Navigation Properties
        [ForeignKey("UsuarioID")]
        public Usuario usuario { get; set; }

    }
}