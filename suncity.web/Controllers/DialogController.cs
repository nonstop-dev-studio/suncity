using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using suncity.web.Models;
using Suncity.Web.Context;

namespace suncity.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DialogController : ControllerBase
    {
        private readonly SuncityContext _context;

        public DialogController(SuncityContext context)
        {
            _context = context;
        }

        // GET: api/dialog
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dialog>>> GetDialog()
        {
            return await _context.Dialogs.ToListAsync();
        }

        // GET: api/dialog/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dialog>> GetDialog(long id)
        {
            var dialog = await _context.Dialogs.FindAsync(id);
            if (dialog == null)
            {
                return NotFound();
            }

            return dialog;
        }

        // POST: api/dialog
        [HttpPost]
        public async Task<ActionResult<Dialog>> CreateDialog(Dialog dialog)
        {
            _context.Dialogs.Add(dialog);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateDialog), new { id = dialog.Id }, dialog);
        }

        // PUT: api/dialog/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutDialog(Guid id, Dialog dialog)
        {
            if (id != dialog.Id)
            {
                return BadRequest();
            }

            _context.Entry(dialog).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/dialog/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDialog(long id)
        {
            var dialog = await _context.Dialogs.FindAsync(id);
            if (dialog == null)
            {
                return NotFound();
            }

            _context.Dialogs.Remove(dialog);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}