using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Suedi.Models.newModels
{
	public class SuediRegistrar
	{
        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Display(Name = "Correo Electronico")]
        public string E_MAIL_A { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
        [Required]
        [StringLength(99)]
        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime Fecha_Nac { get; set; }
        [Required]
        [StringLength(9)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
        public string NombreCurso { get; set; }

    }
}