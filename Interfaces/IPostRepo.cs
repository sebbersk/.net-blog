using Blog.API.Models;

namespace Blog.API.Interfaces
{
    public interface IPostRepo
    {
       IEnumerable<Post> GetPosts();
       void CreatePost(Post post);
       Post GetPost(string id);
       void UpdatePost(Post post);
       void DeletePost(string id);

        IEnumerable<Post> GetPostsByAuthorId(string id);

    }
}