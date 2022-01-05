using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace RTCare.Hubs
{
    public class RTCHAT : Hub
    {
        public async Task SendMessage(string username, string message) 
        {
            await Clients.All.SendAsync("RecieveMessage", username, message);
        }

    }
}
