﻿using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Suedi
{
	public class MyHub1 : Hub
	{
		public void Hello()
		{
			Clients.All.hello();
		}
	}
}