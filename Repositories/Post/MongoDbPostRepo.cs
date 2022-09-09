using Blog.API.Interfaces;
using Blog.API.Models;
using Blog.API.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Blog.API.Repositories
{
    public class MongoDbPostRepo : IPostRepo
    {
        private const string databaseName = "Blog";
        private const string collectionName = "Posts";
        private readonly IMongoCollection<Post> _postCollection;

        public MongoDbPostRepo(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(
            mongoDbSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(databaseName);

            _postCollection = mongoDatabase.GetCollection<Post>(collectionName);
        }
        public void CreatePost(Post post)
        {
            _postCollection.InsertOne(post);
        }

        public void DeletePost(string id)
        {
            _postCollection.DeleteOne(post => post.Id == id);
        }

        public Post GetPost(string id)
        {
            var post = _postCollection.Find(post => post.Id == id).SingleOrDefault();
            return post;
        }

        public IEnumerable<Post> GetPosts()
        {
            var posts = _postCollection.Find(_ => true).ToList();
            return posts;
        }

        public IEnumerable<Post> GetPostsByAuthorId(string id)
        {
            var posts = _postCollection.Find(posts => posts.AuthorId == id).ToList();
            return posts;
        }

        public void UpdatePost(Post post)
        {
            _postCollection.ReplaceOne(exPost => exPost.Id == post.Id,post);
        }
    }
}