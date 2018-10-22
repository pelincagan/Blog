using BlogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogAPI.Controllers
{
    [RoutePrefix("api/Author")]
    public class AuthorController : ApiController
    {
        // GET: api/Author
        [Route("")]
        public IEnumerable<AuthorDTO> Get()
        {
            return null;
        }

        // GET: api/Author/5
        [HttpGet, Route("{id}")]
        public AuthorDTO GetbyId(int id)
        {
            return null;
        }

        // POST: api/Author
        [Route("")] // It takes parameter from body, so it is empty
        public void Post([FromBody]AuthorDTO author)
        {
        }

        // PUT: api/Author/5
        [HttpPut, Route("{id}")]
        public void Update(int id, [FromBody]AuthorDTO author)
        {
        }

        // DELETE: api/Author/5
        [Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}
