﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace DataAccessLayer.Models
{
    
    public class Carrito
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoID { get; set; }
        public int UsuarioID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public List<Producto> productoLista = new List<Producto>();
        //Properties
        [ForeignKey("UsuarioID")]
        public Usuario usuario { get; set; }
        public ICollection<Orden> listOrden { get; set; }

    }
}