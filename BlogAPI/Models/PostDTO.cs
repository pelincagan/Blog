﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAPI.Models
{
    public class PostDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<Tag> Tags { get; set; }
        public Guid AuthorId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}