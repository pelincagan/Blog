using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAPI.Models
{
    public class AuthorDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string Photo { get; set; }
    }
}