using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PuppiesPet.Models;

namespace PuppiesPet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<PuppiesPet.Models.Mascotas> DataMascota { get; set; }
        public DbSet<PuppiesPet.Models.Usuario> Usuarios { get; set; }

        public DbSet<PuppiesPet.Models.Servicio> Servicios { get; set; }

        public DbSet<PuppiesPet.Models.Producto> Productos { get; set; }

        public DbSet<PuppiesPet.Models.CategoriaProducto> CategoriaProductos { get; set; }

        public DbSet<PuppiesPet.Models.Doctor> Doctores { get; set; }

        public DbSet<PuppiesPet.Models.ReservaCita> Reservas { get; set; }


        public DbSet<PuppiesPet.Models.Contactar> Contactar { get; set; }

        public DbSet<PuppiesPet.Models.TrabajaNosotros> Trabajar { get; set; }


        public DbSet<PuppiesPet.Models.Mascota> Mascotas { get; set; }
        public DbSet<PuppiesPet.Models.Proforma> Proforma { get; set; }
    }
}


//FALTA TABLA DE ORDEN DE COMPRA Y PEDIDO
