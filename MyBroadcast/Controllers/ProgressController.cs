using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MyBroadcast.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBroadcast.Controllers
{
    public class ProgressController:Controller
    {
        private readonly IHubContext<NotifyHub> _hubContext;

        public ProgressController(IHubContext<NotifyHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("api/progress")]
        public async Task<IActionResult> Get()
        {
            for (int i = 0; i < 101; i++)
            {
                await _hubContext.Clients.All.SendAsync("receiveNotify", i);
                await Task.Delay(100);
            }
            return Ok("Done");
        }
    }
}
