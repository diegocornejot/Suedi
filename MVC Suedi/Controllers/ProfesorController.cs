using MVC_Suedi.Models;
using MVC_Suedi.Models.newModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Suedi.Controllers
{
    public class ProfesorController : Controller
    {
        public ActionResult RegistroProfesor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistroProfesor(ModeloProfesor model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SuediEntities2 db = new SuediEntities2())
                    {
                        var oAlumno = new Profesor();
                        oAlumno.E_MAIL_P = model.E_MAIL_P;
                        oAlumno.Nombres = model.Nombres;
                        oAlumno.Apellidos = model.Apellidos;
                        oAlumno.Contraseña = model.Contraseña;
                        oAlumno.Fecha_Nac = model.Fecha_Nac;
                        oAlumno.Telefono = model.Telefono;
                        oAlumno.Calificacion = 0;


                        db.Profesor.Add(oAlumno);
                        db.SaveChanges();

                    }
                    return Redirect("~/Inicio/Inicio");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // GET: Profesor
        public ActionResult LoginProfesor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginProfesor(String Correo, String Password)
        {
            try
            {
                using (Models.SuediEntities2 db = new Models.SuediEntities2())
                {
                    var lst = from d in db.Profesor
                              where
d.E_MAIL_P == Correo.Trim() && d.Contraseña ==
Password.Trim()
                              select d;
                    if (lst.Count() > 0)
                    {
                        Profesor oUser = lst.First();
                        Session["User"] = oUser.E_MAIL_P;
                        Session["Type"] = "Profesor";
                        return Redirect("~/Inicio/Inicio");

                    }
                    return View();
                }


            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
       


    }
    
}