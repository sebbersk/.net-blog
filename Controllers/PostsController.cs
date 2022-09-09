using Blog.API.DTOS.Post;
using Blog.API.Extensions;
using Blog.API.Interfaces;
using Blog.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepo _postRepo;
        private readonly ILogger _logger;

        public PostsController(IPostRepo postRepo, ILogger<PostsController> logger) 
        {
            this._postRepo = postRepo;
            this._logger = logger;
        }

        [HttpGet]
        public IEnumerable<PostDTO> GetPosts()
        {
            return _postRepo.GetPosts().Select(post => post.asDTO());
        }

        [HttpPost]
        
        public ActionResult<PostDTO> CreatePost(CreatePostDTO createdPost) 
        {
            Guid PostId = Guid.NewGuid();
            DateTimeOffset CreatedAt = DateTimeOffset.UtcNow;
            Post NewPost = new Post{Id = PostId, Title = createdPost.Title, Content=createdPost.Content, AuthorId= createdPost.AuthorId, CreatedAt = CreatedAt};
            _postRepo.CreatePost(NewPost);
            return NewPost.asDTO();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<PostDTO> GetPost(Guid id)
        {
            var post = _postRepo.GetPost(id);
            
            if (post is null) {
                return NotFound();
            }
            return post.asDTO();
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdatePost(Guid id, UpdatePostDTO postDTO) 
        {
            var post = _postRepo.GetPost(id);

            if (post is null)
            {
                return NotFound();
            }

            post.Title = postDTO.Title;
            post.Content = postDTO.Content;
            _postRepo.UpdatePost(post);
            
            return Content("Post Updated");
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeletePost(Guid id)
        {
            var post = _postRepo.GetPost(id);

            if (post is null)
            {
                return NotFound();
            }

            _postRepo.DeletePost(id);           
            
            return Content("Post Deleted");
        }
    }
}