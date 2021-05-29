using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{


    [Table("t_trabaja")]
    public class TrabajaNosotros
    {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Celular { get; set; }

        public string CorreoElectronico { get; set; }

        public string Curriculum { get; set; }


    }
}