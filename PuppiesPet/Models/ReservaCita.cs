using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{

    [Table("t_reservar")]
    public class ReservaCita
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        public int UsuarioId { get; set; }



        public Mascota Mascota { get; set; }

        public Servicio Servicio { get; set; }

        public Doctor Doctor { get; set; }











    }
}