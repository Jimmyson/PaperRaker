using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PaperRaker.Core.Model.System;
using PaperRaker.DataAccess.Repositories;

namespace PaperRaker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly AuthorRepository _authorRepo = new AuthorRepository();
        
        // GET api/authors
        [HttpGet]
        public IEnumerable<Author> Get(uint size, uint offset)
        {
            //return new string[] {"value1", "value2"};
            return _authorRepo.GetGroup(size, offset);
        }

        // GET api/authors/5
        [HttpGet("{id}")]
        public Author Get(int id)
        {
            //return "value";
            return _authorRepo.Get(id);
        }

        // POST api/authors
        [HttpPost]
        public void Post([FromBody] Author value)
        {
            if (ModelState.IsValid)
                _authorRepo.Add(value);
        }

        // PUT api/authors/5
        [HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        public void Put(int id, [FromBody] Author value)
        {
            value.AuthorId = id;
            if (ModelState.IsValid)
                _authorRepo.Update(value);
        }

        // DELETE api/authors/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _authorRepo.Delete(id);
        }
    }
}