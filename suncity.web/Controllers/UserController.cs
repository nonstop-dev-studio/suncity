//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Suncity.Web.Context;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace suncity.web.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UsersController : ControllerBase
//    {
//        private readonly SuncityContext _context;

//        public UsersController(SuncityContext context)
//        {
//            _context = context;
//        }

//        // GET api/users
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<SunCityUser>>> Get()
//        {
//            return await _context.Users.ToListAsync();
//        }

//        // GET api/users/
//        [HttpGet("{id}")]
//        public async Task<ActionResult<SunCityUser>> Get(Guid id)
//        {
//            var user = await _context.Users.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            return user;
//        }

//        // POST: api/users
//        [HttpPost]
//        public async Task<ActionResult<SunCityUser>> CreateUser(SunCityUser user)
//        {
//            _context.Users.Add(user);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction(nameof(CreateUser), new { id = user.Id }, user);
//        }

//        // PUT: api/users
//        [HttpPut("{id}")]
//        public async Task<ActionResult> UpdateUser(Guid id, SunCityUser user)
//        {
//            if (id != user.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(user).State = EntityState.Modified;
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        // DELETE: api/users
//        [HttpDelete("{id}")]
//        public async Task<ActionResult> DeleteUser(Guid id)
//        {
//            var user = await _context.Users.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            _context.Users.Remove(user);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }
//    }
//}