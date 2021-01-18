using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Suedi.Models;
using MVC_Suedi.Models.newModels;
using System.Data.Entity;

namespace MVC_Suedi.Controllers
{
    public class SuediController : Controller
    {
        // GET: Suedi

        [HttpPost]
        public ActionResult Nuevo(SuediRegistrar model)
		{
			try
			{
				if (ModelState.IsValid)
				{
                    using (SuediEntities2 db = new SuediEntities2())
					{
                        var oAlumno = new Alumno();
                        oAlumno.E_MAIL_A = model.E_MAIL_A;
                        oAlumno.Nombres = model.Nombres;
                        oAlumno.Apellidos = model.Apellidos;
                        oAlumno.Contraseña = model.Contraseña;
                        oAlumno.Fecha_Nac = model.Fecha_Nac;
                        oAlumno.Telefono = model.Telefono;
                        oAlumno.Calificacion = 0;
                        
                     
                        db.Alumno.Add(oAlumno);
                        db.SaveChanges();

                    }
                    return Redirect("~/Inicio/Inicio");
                }
                return View(model);
			}
            catch(Exception ex)
			{
                throw new Exception(ex.Message);
			}
		}
        public ActionResult Nuevo()
        {
            return View();
        }

       
    }
}