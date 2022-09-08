using Blog.API.Models;

namespace Blog.API.Interfaces
{
    public interface IPostRepo
    {
        public IEnumerable<Post> GetPosts();
        public void CreatePost(Post post);
    }
}