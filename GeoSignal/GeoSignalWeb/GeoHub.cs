using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace GeoSignalWeb
{
    public class GeoHub : Hub
    {
        public void UpdatePosition(string id, double lat, double lng)
        {
            Clients.Others.NotifyPosition(id, lat, lng);
        }
    }
}