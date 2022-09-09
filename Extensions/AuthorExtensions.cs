using Blog.API.DTOS.Author;
using Blog.API.Models;

namespace Blog.API.Extensions
{
    public static class AuthorExtensions
    {
        public static AuthorDTO asDTO(this Author author) {
            return new AuthorDTO(author.Id,author.FirstName,author.LastName);
        }
    }
}