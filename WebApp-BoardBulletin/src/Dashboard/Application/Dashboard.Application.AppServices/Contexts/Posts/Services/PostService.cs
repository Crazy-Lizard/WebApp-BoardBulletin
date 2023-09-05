using Dashboard.Application.AppServices.Contexts.Posts.Repositories;
using Dashboard.Contracts;
using Dashboard.Contracts.Post;
using Dashboard.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Application.AppServices.Contexts.Posts.Services
{
    /// <inheritdoc />
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        /// <summary>
        /// Инициализирует экземпляр <see cref="PostService"/>
        /// </summary>
        /// <param name="postRepository">Репозиторий для работы с объявлениями.</param>
        public PostService(IPostRepository postRepository) 
        {  
            _postRepository = postRepository; 
        }

        /// <inheritdoc />
        public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return _postRepository.GetByIdAsync(id, cancellationToken);
        }

        /// <inheritdoc />
        public Task<Guid> CreateAsync(CreatePostDto model, CancellationToken cancellationToken)
        {
            var post = new Post()
            {
                Description = model.Description,
                Price = model.Price,
                Title = model.Title,
                CategoryId = model.CategoryId,
                TagNames = model.TagNames,
            };
            return _postRepository.CreateAsync(post, cancellationToken);
        }
    }
}
