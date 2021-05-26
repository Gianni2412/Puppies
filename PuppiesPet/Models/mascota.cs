using System;

namespace PuppiesPet.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Sexo { get; set; }

        public string Raza { get; set; }

        public string Especie { get; set; }

        public int Edad { get; set; }


        public Decimal Peso { get; set; }

        public string Enfermedades { get; set; }
    }



}