
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PuppiesPet.Models
{
    [Table("t_usuario")]

    public class Usuario
    {

      [DatabaseGenerated(DatabaseGeneratedOption.Identity
    )]
      
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese los nombres")]
        [Display(Name="Nombres Completos")]
        [Column("nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Por favor ingrese los nombres")]
        [Display(Name="Apellidos Completos")]
        [Column("apellidos")]
        public string Apellidos{ get; set; }

        [Required(ErrorMessage = "Por favor ingrese los nombres")]
        [Display(Name="correo del usuario")]
        [Column("correo")]
        public string Correo { get; set; }


       [Required(ErrorMessage = "Por favor ingrese los nombres")]
        [Display(Name="Direccion del usuario")]
        [Column("direccion")]
        public string Direccion { get; set; }
         

        [Required(ErrorMessage = "Por favor ingrese los nombres")]
        [Display(Name="distrito del usuario")]
        [Column("distrito")]
        public string Distrito { get; set;}

        [Required(ErrorMessage = "Por favor ingrese los nombres")]
        [Display(Name="celular del usuario")]
        [Column("phone")]     
        public int Phone { get; set; }


        [Required(ErrorMessage = "Por favor ingrese los nombres")]
        [Display(Name="contraseña del usuario")]
        [Column("contraseña")]   
        public string contraseña { get; set; }

   [NotMapped]
   public String Respuesta { get; set; }


    }

}