using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogAPI.Controllers
{
    [RoutePrefix("api/Author")]
    public class TagController : ApiController
    {
        // GET: api/Tag
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tag/5
        [Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tag
        [HttpPost, Route("")]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tag/5
        [HttpPut, Route("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tag/5
        [HttpDelete, Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}
