using Dashboard.Contracts;
using Dashboard.Contracts.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Application.AppServices.Contexts.Posts.Services
{
    /// <summary>
    /// Сервис работы с объявлениями.
    /// </summary>
    public interface IPostService
    {
        /// <summary>
        /// Возвращает объявление по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель объявления <see cref="PostDto"/>.</returns>
        Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Создаёт объявление по модели.
        /// </summary>
        /// <param name="model">Модель объявление.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Идентификатор созданной сущности.</returns>
        Task<Guid> CreateAsync(CreatePostDto model, CancellationToken cancellationToken);
    }
}
