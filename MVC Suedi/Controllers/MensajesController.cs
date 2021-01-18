using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Suedi.Controllers
{
    public class MensajesController : Controller
    {
        // GET: Mensajes
        public ActionResult Mensaje()
        {
            return View();
        }
    }
}