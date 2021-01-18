using MVC_Suedi.Models;
using MVC_Suedi.Models.newModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Suedi.Controllers
{
    public class AulaAlumnoController : Controller
    {
        // GET: AulaAlumno
        public ActionResult CursosAlumno()
        {
            List<SeleccionaYCursos> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {

                String usuario = Session["User"].ToString();
                lst = (from d in db.Selecciona
                       join s in db.Curso on d.ID_Curso equals s.ID_Curso
                       where d.E_Mail_A == usuario
                       select new SeleccionaYCursos
                       {
                           E_MAIL_P = d.E_Mail_P,
                           Nombre = s.Nombre,
                       }).ToList();
            }
            return View(lst);
        }
        public ActionResult ProfesoresAlumno()
		{
            List<ModeloProfesor> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {

               
                lst = (from d in db.Profesor
                       select new ModeloProfesor
                       {
                           E_MAIL_P = d.E_MAIL_P,
                           Nombres = d.Nombres,
                           Apellidos=d.Apellidos,
                           Telefono=d.Telefono
                       }).ToList();
            }
            return View(lst);

        }

    }
}