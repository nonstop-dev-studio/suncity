using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Suncity.Web.Context;
using Suncity.Web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Suncity.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionnairesController : ControllerBase
    {
        private readonly SuncityContext _context;

        public QuestionnairesController(SuncityContext context)
        {
            _context = context;
        }

        // GET: api/questionnaires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Questionnaire>>> GetQuestionnaires()
        {
            return await _context.Questionnaires.ToListAsync();
        }

        // GET: api/questionnaires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Questionnaire>> GetQuestionnaire(long id)
        {
            var questionnaire = await _context.Questionnaires.FindAsync(id);
            if (questionnaire == null)
            {
                return NotFound();
            }

            return questionnaire;
        }

        // POST: api/questionnaires
        [HttpPost]
        public async Task<ActionResult<Questionnaire>> PostQuestionnaire(Questionnaire questionnaire)
        {
            _context.Questionnaires.Add(questionnaire);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetQuestionnaire), new { id = questionnaire.Id }, questionnaire);
        }

        // PUT: api/questionnaires/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutQuestionnaire(Guid id, Questionnaire questionnaire)
        {
            if (id != questionnaire.Id)
            {
                return BadRequest();
            }

            _context.Entry(questionnaire).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/questionnaires/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteQuestionnaire(long id)
        {
            var questionnaire = await _context.Questionnaires.FindAsync(id);
            if (questionnaire == null)
            {
                return NotFound();
            }

            _context.Questionnaires.Remove(questionnaire);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}