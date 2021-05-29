using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{


    [Table("t_doctor")]

    public class Doctor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}