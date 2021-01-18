using MVC_Suedi.Models;
using MVC_Suedi.Models.newModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Suedi.Controllers
{
    public class MatriculadoController : Controller
    {
        // GET: Matriculado
        public ActionResult Matriculado(SuediRegistrar model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SuediEntities2 db = new SuediEntities2())
                    {
                        var oAlumno = new Alumno();
                        oAlumno.E_MAIL_A = "diego";
                        oAlumno.Nombres = model.Nombres;
                        oAlumno.Apellidos = model.Apellidos;
                        oAlumno.Contraseña = model.Contraseña;
                        oAlumno.Fecha_Nac = model.Fecha_Nac;
                        oAlumno.Telefono = model.Telefono;


                        db.Alumno.Add(oAlumno);
                        db.SaveChanges();

                    }
                    return Redirect("~/Inicio/Inicio");
                }
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}