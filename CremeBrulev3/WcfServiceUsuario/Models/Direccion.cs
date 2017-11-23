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
    public class Direccion
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionID { get; set; }
        [DataMember]
        public int UsuarioID { get; set; }
        [DataMember]
        [Required]
        public string Colonia { get; set; }
        [DataMember]
        [Required]
        public string Calle { get; set; }
        [DataMember]
        [Required]
        public string Estado { get; set; }
        [DataMember]
        [Required]
        public string Ciudad { get; set; }
        [DataMember]
        public int CodigoPostal { get; set; }


        //Navigation Properties
        [DataMember]
        [ForeignKey("UsuarioID")]
        public Usuario usuario { get; set; }

    }
}