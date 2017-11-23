using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CremeBrulev3.Models
{
    public class Cuenta
    {
      

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CuentaID { get; set; }
        public int UsuarioID { get; set; }
        public bool CuentaVerificada { get; set; } = false;

        //NavigatioProperty
        [ForeignKey("UsuarioID")]
        public Usuario usuario { get; set; }
        public ICollection<Carrito> listCarrito { get; set; }
        public ICollection<Direccion> listDireccion { get; set; }
        public ICollection<Orden> listOrden { get; set; }

    }
}