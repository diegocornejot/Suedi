using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Suedi.Controllers;
using MVC_Suedi.Models;

namespace MVC_Suedi.Filtros
{
	public class VerificaLogin : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			
			if (HttpContext.Current.Session["User"] == null)
			{
				if(filterContext.Controller is LoginController == false && filterContext.Controller is SuediController == false && filterContext.Controller is ProfeOAlumController == false && filterContext.Controller is ProfesorController == false && filterContext.Controller is InicioController == false)
				{
					filterContext.HttpContext.Response.Redirect("~/Inicio/Inicio");
				}
			}
		}
		
	}
}