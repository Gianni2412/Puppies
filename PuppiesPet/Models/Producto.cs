using System;

namespace PuppiesPet.Models
{
    public class Producto

    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string ImagenName { get; set; }

        public Decimal Precio { get; set; }

        public int Cantidad { get; set; }
        public String Status { get; set; }
        public CategoriaProducto categorias { get; set; }

        public int CategoriaId { get; set; }

    }
}