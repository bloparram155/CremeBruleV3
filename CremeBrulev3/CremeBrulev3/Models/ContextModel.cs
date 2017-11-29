using System;
using System.Collections.Generic;
using System.Data.Entity;
using DataAccessLayer.Models;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CremeBrulev3.Models
{
    public class ContextModel : DbContext
    {

        public DbSet<Carrito> Carrito { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public ContextModel() : base("name = FarmaciaModel")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}