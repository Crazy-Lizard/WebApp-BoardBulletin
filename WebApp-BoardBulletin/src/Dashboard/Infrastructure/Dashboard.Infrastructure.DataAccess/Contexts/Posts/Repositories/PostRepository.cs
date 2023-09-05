using Dashboard.Application.AppServices.Contexts.Posts.Repositories;
using Dashboard.Contracts;
using Dashboard.Contracts.Attachment;
using Dashboard.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Posts.Repositories
{
    /// <inheritdoc/>
    public class PostRepository : IPostRepository
    {
        private readonly List<Domain.Posts.Post> _posts = new();

        /// <inheritdoc/>
        public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Task.Run(() => new PostDto
            {
                Id = Guid.NewGuid(),
                Title = "Тестовое название",
                Description = "Тестовое описание",
                CategoryName = "Тестовая категория",
                TagNames = new[] { "Тестовые", "Теги" },
                //Attachments = new[] { new AttachmentEntity { Id = Guid.NewGuid(), Content = new byte[] { 111, 222, 11, 254 } } },
                Price = 100,
            }, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<Guid> CreateAsync(Post model, CancellationToken cancellationToken)
        {
            model.Id = Guid.NewGuid();
            _posts.Add(model);
            return Task.Run(() =>  model.Id);
        }
    }
}
