using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NPoco;
using PaperRaker.Core.Model.System;
using PaperRaker.DataAccess.Repositories;

namespace PaperRaker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PapersController : Controller
    {
        private readonly PaperRepository _paperRepo = new PaperRepository();
        
        // GET api/papers
        [HttpGet]
        public IEnumerable<Paper> Get(uint size, uint offset)
        {
            //return new string[] {"value1", "value2"};
            return _paperRepo.GetGroup(size, offset);
        }
                
        // GET api/papers?offset=20&size=10
        //[HttpGet]
        //public IEnumerable<Paper> Get(uint size, uint? offset)
        //{
            //return new string[] {"value1", "value2"};
        //    return _paperRepo.GetGroup(size, offset);
        //}

        // GET api/papers/5
        [HttpGet("{id}")]
        public Paper Get(int id)
        {
            //return "value";
            return _paperRepo.Get(id);
        }

        // POST api/papers
        [HttpPost]
        public void Post([FromBody] Paper value)
        {
            if (ModelState.IsValid)
                _paperRepo.Add(value);
        }

        // PUT api/papers/5
        [HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        public void Put(int id, [FromBody] Paper value)
        {
            value.Id = id;
            if (ModelState.IsValid)
                _paperRepo.Update(value);
        }

        // DELETE api/papers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _paperRepo.Delete(id);
        }
    }
}