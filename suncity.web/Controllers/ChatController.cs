using Microsoft.AspNetCore.Mvc;
using suncity.web.Chat;
using Suncity.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace suncity.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly ChatHub _chatHub;

        public ChatController(ChatHub chatHub)
        {
            _chatHub = chatHub;
        }

        // GET: api/questionnaires
        [HttpGet]
        public async Task<IEnumerable<ChatConnection>> GetOnlineUsers()
        {
            return await _chatHub.GetAllActiveConnections();
        }
    }
}