using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Suedi.Models.newModels
{
	public class SuediNewModel
	{
        public string E_MAIL_A { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Contraseña { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Telefono { get; set; }
        public int Calificacion { get; set; }
        public byte[] Foto { get; set; }
    }
}