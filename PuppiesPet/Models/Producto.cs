using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{
 [Table("t_producto")]


    public class Productos

    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string ImagenName { get; set; }

        public Decimal Precio { get; set; }

        public int Cantidad { get; set; }


        public String Status { get; set; }

        
    }
}