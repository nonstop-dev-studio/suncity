using Microsoft.AspNetCore.Mvc;
using suncity.web.Models.User;
using System;
using System.Collections.Generic;

namespace suncity.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<SunCityUser>> Get()
        {
            return new JsonResult(GenerateSunCityUsers());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<SunCityUser> Get(Guid id)
        {
            var SCUser = GenerateUser();
            SCUser.Id = id;
            return SCUser;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] SunCityUser value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] SunCityUser value)
        {
            // TODO implement
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            // TODO delete
        }

        private static IEnumerable<SunCityUser> GenerateSunCityUsers()
        {
            int usersCount = 5;
            for(int i = 0; i < usersCount; i++)
            {
                yield return GenerateUser();
            }
        }

        private static SunCityUser GenerateUser()
        {
            return new SunCityUser
            {
                Id = Guid.NewGuid(),
                Name = "Василий",
                Surname = "Сидоров",
                MiddleName = "Петрович",
                BirthDate = DateTime.Now + TimeSpan.FromDays(5000),
                Email = "nonstop.vk.hack@vk.hack.run",
                LastLogon = DateTime.Now,
                Registered = DateTime.Now + TimeSpan.FromDays(-100),
                PhoneNumber = "+7890123456",
                UserName = "NonStop"
            };
        }
    }
}