using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PaperRaker.Core.Model.System;
using PaperRaker.DataAccess.Repositories;

namespace PaperRaker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class InstitutionsController : Controller
    {
        private readonly InstitutionRepository _institutionRepo = new InstitutionRepository();
        
        // GET api/institutions
        [HttpGet]
        public IEnumerable<Institution> Get(uint size, uint offset)
        {
            //return new string[] {"value1", "value2"};
            return _institutionRepo.GetGroup(size, offset);
        }

        // GET api/institutions/5
        [HttpGet("{id}")]
        public Institution Get(int id)
        {
            //return "value";
            return _institutionRepo.Get(id);
        }

        // POST api/institutions
        [HttpPost]
        public void Post([FromBody] Institution value)
        {
            if (ModelState.IsValid)
                _institutionRepo.Add(value);
        }

        // PUT api/institutions/5
        [HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        public void Put(int id, [FromBody] Institution value)
        {
            value.InstitutionId = id;
            if (ModelState.IsValid)
                _institutionRepo.Update(value);
        }

        // DELETE api/institutions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _institutionRepo.Delete(id);
        }
    }
}