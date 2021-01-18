using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Suedi.Controllers
{
    public class CerrarController : Controller
    {
        // GET: Cerrar
        public ActionResult Cerrar()
        {
            Session["User"] = null;
            Session["Type"] = null;
            return RedirectToAction("Inicio", "Inicio");
        }
    }
}