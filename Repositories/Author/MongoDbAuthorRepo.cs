using Blog.API.Interfaces;
using Blog.API.Models;
using Blog.API.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Blog.API.Repositories
{
    public class MongoDbAuthorRepo : IAuthorRepo
    {
        private const string databaseName = "Blog";
        private const string collectionName = "Authors";
        private readonly IMongoCollection<Author> _authorCollection;

        public MongoDbAuthorRepo(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(
            mongoDbSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(databaseName);

            _authorCollection = mongoDatabase.GetCollection<Author>(collectionName);
        }
        public void CreateAuthor(Author author)
        {
            _authorCollection.InsertOne(author);
        }

        public void DeleteAuthor(string id)
        {
            _authorCollection.DeleteOne(author => author.Id == id);
        }

        public Author GetAuthor(string id)
        {
            return _authorCollection.Find(author => author.Id == id).SingleOrDefault();
        }

        public void UpdateAuthor(Author author)
        {
            _authorCollection.ReplaceOne(exAuthor => exAuthor.Id == author.Id,author);
        }
    }
}