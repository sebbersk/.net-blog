using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.API.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        [BsonRepresentation(BsonType.ObjectId)]
        public string? AuthorId{ get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        
    }
}