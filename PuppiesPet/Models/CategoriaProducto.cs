using System.Collections.Generic;

namespace PuppiesPet.Models
{
    public class CategoriaProducto 
    {
        public int id { get; set; }

        public int Nombre { get; set; }

       public ICollection<Producto> Productos { get; set; }
    }
}