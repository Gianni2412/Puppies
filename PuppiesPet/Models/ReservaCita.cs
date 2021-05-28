using System;

namespace PuppiesPet.Models
{
    public class ReservaCita
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }


        //CLASES EXTERNAS

        public Usuario Usuario { get; set; }

        public Mascotas Mascota { get; set; }

        public Servicio Servicio { get; set; }

        public Doctor Doctor { get; set; }



        // EF S.P
        public int UsuarioId { get; set; }

        public int MascotasId { get; set; }

        public int ServicioId { get; set; }

        public int DoctorId { get; set; }





        //traer idusuario,idmascota,idServicio,idDoctor
    }
}