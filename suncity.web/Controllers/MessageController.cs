using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Suncity.Web.Context;
using suncity.web.Models;
using Microsoft.EntityFrameworkCore;

namespace suncity.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly SuncityContext _context;

        public MessageController(SuncityContext context)
        {
            _context = context;
        }

        // GET: api/message
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessage()
        {
            return await _context.Messages.ToListAsync();
        }

        // GET: api/message/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessage(string key)
        {
            var returnMessage = _context.Messages.Where(m => m.Key == key).ToListAsync();
            return await returnMessage;
        }

        // POST: api/message
        [HttpPost]
        public async Task<ActionResult<Dialog>> CreateMessage(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateMessage), new { id = message.Id }, message);
        }

        // PUT: api/message/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutMessage(Guid id, Message message)
        {
            if (id != message.Id)
            {
                return BadRequest();
            }

            _context.Entry(message).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/message/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMessage(long id)
        {
            var message = await _context.Messages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }

            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}