namespace PuppiesPet.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int Dni { get; set; }

        public string Distrito { get; set; }
        public string Direccion { get; set; }

        public int Celular { get; set; }

        public string Contraseña { get; set; }

        public string CorreoElectronico { get; set; }
    }
}