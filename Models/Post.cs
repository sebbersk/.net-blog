using System;

namespace Blog.API.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Guid AuthorId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        
    }
}