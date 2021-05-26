using System;

namespace PuppiesPet.Models
{
    public class ReservaCita
    {
        public int Id { get; set; }

        public DateTime fecha { get; set; }

        public DateTime hora { get; set; }

        //traer idusuario,idmascota,idEspecie,idDoctor
    }
}