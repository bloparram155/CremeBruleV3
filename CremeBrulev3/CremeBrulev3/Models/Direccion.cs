using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CremeBrulev3.Models
{
    public class Direccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionID { get; set; }
        public int CuentaID { get; set; }
        [Required]
        public string Colonia { get; set; }
        [Required]
        public string Calle { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }


        //Navigation Properties
        [ForeignKey("CuentaID")]
        public Cuenta cuenta { get; set; }

    }
}