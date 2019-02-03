using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MyBroadcast.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBroadcast.Controllers
{
    public class HomeController:Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
    }
}
