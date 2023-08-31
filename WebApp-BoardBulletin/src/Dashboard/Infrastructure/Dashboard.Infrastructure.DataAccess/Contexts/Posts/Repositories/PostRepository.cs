using Dashboard.Application.AppServices.Contexts.Posts.Repositories;
using Dashboard.Contracts;
using Dashboard.Contracts.Attachment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Posts.Repositories
{
    public class PostRepository : IPostRepository
    {
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
    }
}
