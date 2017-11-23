using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceUsuario.Models
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }
        [DataMember]
        [Required]
        public string Nombre { get; set; }
        [DataMember]
        [Required]
        public string Email { get; set; }
        [DataMember]
        [Required]
        public string Password { get; set; }
        [DataMember]
        public string TipoUsuario { get; set; } = "USER";
        [DataMember]
        public bool CuentaVerificada { get; set; } = false;

        //NavigatioProperty
        [DataMember]
        public ICollection<Carrito> listCarrito { get; set; }
        [DataMember]
        public ICollection<Direccion> listDireccion { get; set; }
        [DataMember]
        public ICollection<Orden> listOrden { get; set; }

    }
}