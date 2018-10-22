using BlogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogAPI.Controllers
{
    [RoutePrefix("api/Post")]
    public class PostController : ApiController
    {
        // GET: api/Post
        [Route("")]
        public IEnumerable<PostDTO> Get()
        {
            return null;
        }

        // GET: api/Post/5
        [Route("{id}")]
        public PostDTO Get(int id)
        {
            return null;
        }

        // POST: api/Post
        [HttpPost, Route("")]
        public void CreatePost([FromBody]PostDTO post)
        {
        }

        // PUT: api/Post/5
        [HttpPut, Route("{id}")]
        public void Update(int id, [FromBody]PostDTO post)
        {
        }

        // PUT: api/Post/5
        [HttpPut, Route("revertToDraft/{id}")]
        public void RevertToDraft(int id)
        {
        }

        // PUT: api/Post/5
        [HttpPut, Route("publish/{id}")]
        public void Publish(int id)
        {
        }

        // DELETE: api/Post/5
        [HttpDelete, Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}
