using Blog.API.Models;

namespace Blog.API.Interfaces
{
    public interface IPostRepo
    {
       IEnumerable<Post> GetPosts();
       void CreatePost(Post post);
       Post GetPost(Guid id);
       void UpdatePost(Post post);

       void DeletePost(Guid id);
    }
}