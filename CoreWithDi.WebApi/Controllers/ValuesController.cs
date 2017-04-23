using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWithDi.Business.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CoreWithDi.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IClass1 _class1;
        public ValuesController(IClass1 class1)
        {
            _class1 = class1;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _class1.GetValues();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _class1.GetValue();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
