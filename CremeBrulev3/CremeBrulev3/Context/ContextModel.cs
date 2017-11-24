using CremeBrulev3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CremeBrulev3.Context
{
    public class ContextModel :DbContext
    {

        DbSet<Carrito> Carrito { get; set; }
        DbSet<Direccion> Direccion { get; set; }
        DbSet<Orden> Orden { get; set; }
        DbSet<Producto> Producto { get; set; }
        DbSet<Usuario> Usuario { get; set; }
        public ContextModel() :base ("name = FarmaciaModel")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}