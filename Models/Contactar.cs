using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{

    [Table("t_contactar")]
    public class Contactar
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID{ get; set; }

        public string Nombres { get; set; }

        public string NombreMascota { get; set; }

        public string CorreoElectronico { get; set; }

        public string Asunto { get; set; }
    }
}