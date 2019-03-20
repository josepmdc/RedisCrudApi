using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedisCrudApi.Business.Facade.Repositories;

namespace RedisCrudApi.Business.Facade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentRepository repo;
        public StudentController()
        {
            // This should be injected but for simplicity I will do it like this
            repo = new StudentRepository();
        }

        // GET api/student
        [HttpGet]
        public ActionResult<string> Get()
        {
            return repo.ReadStudent("student1");
        }

        // GET api/student/student1
        [HttpGet("{key}")]
        public ActionResult<string> Get(string key)
        {
            return repo.ReadStudent(key);
        }

        // POST api/student
        [HttpPost("{key}")]
        public void Post(string key, [FromBody] string value)
        {
            repo.CreateStudent(key, value);
        }

        // PUT api/student/student1
        [HttpPut("{key}")]
        public void Put(string key, [FromBody] string value)
        {
            repo.UpdateStudent(key, value);
        }

        // DELETE api/student/student1
        [HttpDelete("{key}")]
        public void Delete(string key)
        {
            repo.DeleteStudent(key);
        }
    }
}
