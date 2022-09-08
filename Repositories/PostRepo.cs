using Blog.API.Interfaces;
using Blog.API.Models;

namespace Blog.API.Repositories
{
    public class PostRepo : IPostRepo
    {
        private readonly List<Post> posts = new(){
            new Post {Id= Guid.NewGuid(), Title = "Post 1", Content ="Hello World!", AuthorId = Guid.NewGuid(), CreatedAt=DateTimeOffset.UtcNow},
            new Post {Id= Guid.NewGuid(), Title = "Post 2", Content ="Hello There!", AuthorId = Guid.NewGuid(), CreatedAt=DateTimeOffset.UtcNow}
        };

        public void CreatePost(Post post)
        {
            posts.Add(post);
        }

        public IEnumerable<Post> GetPosts()
        {
             return posts;
        }

        
    }
}