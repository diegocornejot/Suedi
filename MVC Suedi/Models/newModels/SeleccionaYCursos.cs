using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Suedi.Models.newModels
{
	public class SeleccionaYCursos
	{
        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Display(Name = "Correo Electronico")]
        public string E_MAIL_P { get; set; }
        [Required]

        [Display(Name = "ID_Curso")]
        public int ID_CursoC { get; set; }
        public int ID_CursoS { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(99)]
        [Display(Name = "Tipo_Categoria")]
        public string Tipo_Categoria { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public int ID_Selecciona { get; set; }
        public int E_MAIL_A { get; set; }


    }
}