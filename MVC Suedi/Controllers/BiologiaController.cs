using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Suedi.Models;
using MVC_Suedi.Models.newModels;

namespace MVC_Suedi.Controllers
{
    public class BiologiaController : Controller
    {
        // GET: Biologia
        public ActionResult Biologia()
        {
            List<ModeloCursos> lst;
            using (SuediEntities2 db = new SuediEntities2())
            {
                lst = (from d in db.Curso
                       where d.Tipo_Categoria == "Biologia"
                       select new ModeloCursos
                       {
                           ID_Curso = d.ID_Curso,
                           Nombre = d.Nombre,
                           E_MAIL_P = d.E_Mail_P,
                           Estado = d.Estado,

                       }).ToList();
            }
            return View(lst);
        }
        [Route("Matricular/{ID_Curso:int}")]
        public ActionResult Matricular(int id)
        {

            if (ModelState.IsValid)
            {
                using (SuediEntities2 db = new SuediEntities2())
                {
                    var lst = from d in db.Selecciona
                              orderby d.ID_Selecciona descending

                              select d;

                    Selecciona oUser = lst.First();
                    var otabla = db.Curso.Find(id);
                    var tabla = new Selecciona();
                    tabla.ID_Selecciona = oUser.ID_Selecciona + 1;
                    tabla.ID_Curso = otabla.ID_Curso;
                    tabla.E_Mail_A = Session["User"].ToString();
                    tabla.E_Mail_P = otabla.E_Mail_P;



                    db.Selecciona.Add(tabla);
                    db.SaveChanges();

                }
                return View();
            }
            return Redirect("~/Inicio/Inicio");





        }
    }
}