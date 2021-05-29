using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{

    [Table("t_categoriaproducto")]
    public class CategoriaProducto
    {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Producto productoId { get; set; }


    }
}