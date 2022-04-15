using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace DylanReedChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }
        public async Task TypingIndicator(string name, string message)
        {
            await Clients.Others.SendAsync("TypingIndicator", name, message);
        }
        public async Task RemoveTypingIndicator(string name)
        {
            await Clients.Others.SendAsync("RemoveTypingIndicator", name);
        }
    }
}