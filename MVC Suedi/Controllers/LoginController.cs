using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Suedi.Models;

namespace MVC_Suedi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String Correo, String Password)
        {
            try
            {
                using (Models.SuediEntities2 db = new Models.SuediEntities2())
                {
                    var lst = from d in db.Alumno
                                 where
 d.E_MAIL_A == Correo.Trim() && d.Contraseña ==
 Password.Trim()
                                 select d;
                    if (lst.Count()>0)
                    {
                        Alumno oUser = lst.First();
                        Session["User"] = oUser.E_MAIL_A;
                        Session["Type"] = "Alumno";
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