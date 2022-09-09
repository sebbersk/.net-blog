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

        public void DeletePost(Guid id)
        {
            var postIndex = posts.FindIndex(post => post.Id == id);
            posts.RemoveAt(postIndex);
        }

        public Post GetPost(Guid id)
        {
            var post = posts.Where(post => post.Id == id).SingleOrDefault();
            return post;
        }

        public IEnumerable<Post> GetPosts()
        {
             return posts;
        }

        public void UpdatePost(Post updatedPost)
        {
            var postIndex = posts.FindIndex( post => post.Id == updatedPost.Id);
            posts[postIndex] = updatedPost;
        }
    }
}