using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PuppiesPet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PuppiesPet.Models.Mascotas> DataMascota { get; set; }
        public DbSet<PuppiesPet.Models.Usuario> DataUsuarios { get; set; }
  
        public DbSet<PuppiesPet.Models.Servicio> DataServicios{ get; set; }

        public DbSet<PuppiesPet.Models.Producto> DataProductos { get; set; }

        public DbSet<PuppiesPet.Models.CategoriaProducto> DataCategoria { get; set; }

        public DbSet<PuppiesPet.Models.Doctor> DataDoctores { get; set; }

        public DbSet<PuppiesPet.Models.ReservaCita> DataReservas { get; set; }

         public DbSet<PuppiesPet.Models.Contactar> DataContactar { get; set; }

          public DbSet<PuppiesPet.Models.TrabajaNosotros> DataTrabajar { get; set; }
    }
}


//FALTA TABLA DE ORDEN DE COMPRA Y PEDIDO
