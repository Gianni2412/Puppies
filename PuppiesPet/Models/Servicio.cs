using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{
    [Table("t_servicio")]
    public class Servicio
    {

        public int Id { get; set; }

        public string Nombres { get; set; }




    }
}