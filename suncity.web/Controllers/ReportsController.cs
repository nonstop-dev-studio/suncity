using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Suncity.Web.Context;
using Suncity.Web.Models;

namespace Suncity.Web.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase {

        private readonly SuncityContext _context;

        public ReportsController (SuncityContext context) {
            _context = context;
        }

        // GET: api/reports
        [HttpGet]
        [Route("/api/reports")]
        public async Task<ActionResult<IEnumerable<Report>>> GetReports() {
            return await _context.Reports.ToListAsync();
        }

        // GET: api/reports/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Report>> GetReport (long id) {
            var report = await _context.Reports.FindAsync (id);
            if (report == null) {
                return NotFound ();
            }

            return report;
        }

        // POST: api/reports
        [HttpPost]
        public async Task < ActionResult < Report>> PostReport(Report report) {
            if (User.Identity.Name != null)
            {
                report.Mentor = User.Identity.Name;
                _context.Reports.Add(report);
            }
            else
            {
                report.Mentor = "Неизвестный";
            }
            await _context.SaveChangesAsync ();
            return CreatedAtAction (nameof (GetReport), new { id = report.Id }, report);
        }

        // PUT: api/reports/5
        [HttpPut ("{id}")]
        public async Task<ActionResult> PutReport (long id, Report report) {
            if (id != report.Id) {
                return BadRequest ();
            }

            _context.Entry (report).State = EntityState.Modified;
            await _context.SaveChangesAsync ();

            return NoContent ();
        }

        // DELETE: api/reports/5
        [HttpDelete ("{id}")]
        public async Task<ActionResult> DeleteReport (long id) {
            var report = await _context.Reports.FindAsync (id);
            if (report == null) {
                return NotFound ();
            }

            _context.Reports.Remove (report);
            await _context.SaveChangesAsync ();

            return NoContent ();
        }
    }
}