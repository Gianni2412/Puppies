using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{
    [Table("t_usuario")]

    public class Usuario
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }


        public string Distrito { get; set; }


        public string Direccion { get; set; }

        public int Celular { get; set; }



       // public string Password { get; set; }

       // public string CorreoElectronico { get; set; }
    }
}