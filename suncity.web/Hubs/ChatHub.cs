using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Suncity.Web.Context;
using Suncity.Web.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace suncity.web.Chat
{
    public class ChatHub : Hub
    {
        private readonly SuncityContext _context;
        private static ConcurrentDictionary<string, DateTime> connectedUsers;

        public ChatHub(SuncityContext context)
        {
            _context = context;
        }

        public async Task Send(string nick, string message, string id)
        {
            Debug.WriteLine($"Received message {message} from {Context.ConnectionId} to {id}");
            await Clients.Client(id).SendAsync("Receive", nick, message, id);
        }

        public async Task<IEnumerable<ChatConnection>> GetAllActiveConnections()
        {
            return await _context.ChatConnections.ToListAsync();
        }

        public override async Task OnConnectedAsync()
        {
            var id = Context.ConnectionId;
            //_context.ChatConnections.Add(new ChatConnection
            //{
            //    ChatConnectionId = id,
            //    Connected = DateTime.UtcNow,
            //    UserId = "current user id" // TODO set real user ID
            //});

            //await _context.SaveChangesAsync();
            if(connectedUsers == null)
            {
                connectedUsers = new ConcurrentDictionary<string, DateTime>();
            }

            connectedUsers.TryAdd(id, DateTime.Now);
            Debug.WriteLine($"{Context.ConnectionId} connected");
            //await Clients
            //    .AllExcept( new List<string>() { Context.ConnectionId })
            //    .SendAsync("Notify", $"{Context.ConnectionId} вошел в чат");
            await BroadcastOnlineUsers(connectedUsers.ToArray());
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var id = Context.ConnectionId;
            //var conn = new ChatConnection
            //{
            //    ChatConnectionId = id,
            //    Connected = DateTime.UtcNow,
            //    UserId = "current user id" // TODO set real user ID
            //};

            //_context.ChatConnections.Remove(conn);
            //await _context.SaveChangesAsync();

            connectedUsers?.TryRemove(id, out var dt);
            await BroadcastOnlineUsers(connectedUsers?.ToArray());
            Debug.WriteLine($"{Context.ConnectionId} disconnected");
            //await Clients.All.SendAsync("Notify", $"{Context.ConnectionId} покинул в чат");
            await base.OnDisconnectedAsync(exception);
        }

        private async Task BroadcastOnlineUsers(KeyValuePair<string, DateTime>[] onlineUsers)
        {
            await Clients
                .AllExcept(new List<string>() { Context.ConnectionId })
                .SendAsync("Notify", onlineUsers);
        }
    }
}
