using MVC_Suedi.Models;
using MVC_Suedi.Models.newModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Suedi.Controllers
{
    public class AulaProfesorController : Controller
    {
        // GET: AulaProfesor
        public ActionResult Calificacion()
        {
            List<ModeloProfesor> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {

                String usuario = Session["User"].ToString();
                lst = (from d in db.Profesor
                       where d.E_MAIL_P == usuario
                       select new ModeloProfesor
                       {
                           Calificacion = (int)d.Calificacion
                       }).ToList();
            }
            return View(lst);
        }
        public ActionResult CursosCreadosProfesor()
        {
            List<ModeloCursos> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {

                String usuario = Session["User"].ToString();
                lst = (from d in db.Curso
                       where d.E_Mail_P == usuario
                       select new ModeloCursos
                       {
                           ID_Curso = d.ID_Curso,
                           Nombre = d.Nombre,
                           Tipo_Categoria = d.Tipo_Categoria,
                           Estado = d.Estado
                       }).ToList();
            }
            return View(lst);
        }
       
        [HttpPost]
        public ActionResult IngresarCurso(ModeloCursos model)
        {
            try
            {
              
                
                    using (SuediEntities2 db = new SuediEntities2())
                    {
                        String email = Session["User"].ToString();
                        var oAlumno = new Curso();
                        oAlumno.E_Mail_P = email;
                        oAlumno.ID_Curso = model.ID_Curso;
                        oAlumno.Nombre = model.Nombre;
                        oAlumno.Tipo_Categoria = model.Tipo_Categoria;
                        oAlumno.Estado = 1;


                        db.Curso.Add(oAlumno);
                        db.SaveChanges();

                    }
                    return Redirect("~/AulaProfesor/CursosCreadosProfesor");
               
             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public ActionResult IngresarCurso()
        {
            return View();
        }
        public ActionResult PerfilProfesor()
        {
            List<ModeloProfesor> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {
                String email = Session["User"].ToString();
                lst = (from d in db.Profesor
                       where d.E_MAIL_P == email
                       select new ModeloProfesor
                       {
                           Nombres = d.Nombres,
                           Apellidos = d.Apellidos,
                           E_MAIL_P = d.E_MAIL_P,
                           Contraseña = d.Contraseña,
                           Telefono = d.Telefono,
                           Calificacion = (int)d.Calificacion,
                       }).ToList();


                return View(lst);
            }
        }
        public ActionResult EstudiantesProfesor()
		{
            List<SuediRegistrar> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {

                String usuario = Session["User"].ToString();
                lst = (from d in db.Selecciona
                       join a in db.Alumno on d.E_Mail_A equals a.E_MAIL_A
                       join c in db.Curso on d.ID_Curso equals c.ID_Curso
                       where d.E_Mail_P == usuario
                       select new SuediRegistrar
                       {
                           E_MAIL_A = a.E_MAIL_A,
                           Nombres = a.Nombres,
                           Apellidos = a.Apellidos,
                           Telefono = a.Telefono,
                           NombreCurso=c.Nombre
                       }).ToList();
            }
            return View(lst);
        }
    }
}