using Microsoft.AspNetCore.SignalR;

namespace SignalR_App.Hubs
{
	public class ChatHub:Hub
	{
		public async Task SendMessage(string name,string message)
		{
			await Clients.All.SendAsync("NewMessage",name, message);
		}
        public async Task SendLocation(string color, int x,int y)
        {
            await Clients.All.SendAsync("LocationReceived", Context.ConnectionId,color,x,y);
        }
    }
}
