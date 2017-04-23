using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMVC.CORE;
using TiendaMVC.CORE.Interfaces;

namespace TiendaMVC.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        ///En caso de que falle por motivo de referencias cruzadas
        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasRequired(f => f.BillingAddress)
                .WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<Order>().HasRequired(f => f.ShippingAddress)
                .WithMany().WillCascadeOnDelete(false);
            
            base.OnModelCreating(modelBuilder);
        }*/


        
        /// <summary>
        /// Colección persistible de Direcciones
        /// </summary>
        public DbSet<Address> Addresses { get; set; }
        /// <summary>
        /// Colección persistible de Categorías
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        /// <summary>
        /// Colección persistible de Ficheros
        /// </summary>
        public DbSet<Document> Documents { get; set; }
        /// <summary>
        /// Colección persistible de Pedidos
        /// </summary>
        public DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Colección persistible de Pedidos de Líneas
        /// </summary>
        public DbSet<OrderLine> OrderLines { get; set; }
        /// <summary>
        /// Colección persistible de Productos
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Colección persistible de Shopping Carts
        /// </summary>
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        /// <summary>
        /// Colección persistible de impuestos
        /// </summary>
        public DbSet<Tax> Tax { get; set; }



        public System.Data.Entity.Infrastructure.DbEntityEntry<T> Entry<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
