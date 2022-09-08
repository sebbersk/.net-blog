using Blog.API.DTOS.Post;
using Blog.API.Models;

namespace Blog.API.Extensions
{
    public static class PostExtensions
    {
        public static PostDTO asDTO(this Post post) {
            return new PostDTO(post.Id,post.Title,post.Content,post.AuthorId,post.CreatedAt);
        }
    }
}