using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Suedi.Models;
using MVC_Suedi.Models.newModels;

namespace MVC_Suedi.Controllers
{
    public class AulaVirtualV2Controller : Controller
    {
        // GET: AulaVirtualV2
        public ActionResult AulaVirtual()
        {
            return View();
        }
        public ActionResult AulaVirtualPerfil()
        {
            List<SuediNewModel> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {
                String email= Session["User"].ToString();
                lst = (from d in db.Alumno
                       where d.E_MAIL_A == email
                       select new SuediNewModel {
                           Nombres = d.Nombres,
                           Apellidos = d.Apellidos,
                           E_MAIL_A = d.E_MAIL_A,
                           Contraseña = d.Contraseña,
                           Telefono = d.Telefono,
                           Calificacion = (int)d.Calificacion,
                       }).ToList();


                return View(lst);
            }
            
        }
        public ActionResult AulaVirtualCursos()
        {
            List<SeleccionaYCursos> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {

                String usuario = Session["User"].ToString();
                lst = (from d in db.Selecciona join s in db.Curso on d.ID_Curso equals s.ID_Curso
                       where d.E_Mail_A == usuario
                       select new SeleccionaYCursos
                       {
                           E_MAIL_P = d.E_Mail_P,
                           Nombre = s.Nombre,
                       }).ToList();
            }
            return View(lst);
          
        }
    }
}