using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataAccessLayer.Models
{
    
    public class Usuario
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string TipoUsuario { get; set; } = "USER";
        public bool CuentaVerificada { get; set; } = false;

        //NavigatioProperty
        public ICollection<Carrito> listCarrito { get; set; }
        public ICollection<Direccion> listDireccion { get; set; }
        public ICollection<Orden> listOrden { get; set; }

    }
}