
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{

    [Table("t_mascota")]
    public class mascota
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idM")]

        public int ID { get; set; }
        public string Nombre { get; set; }


        public string Sexo { get; set; }

        public string fecha { get; set; }

        public string Raza { get; set; }

        public string Especie { get; set; }


    }
}