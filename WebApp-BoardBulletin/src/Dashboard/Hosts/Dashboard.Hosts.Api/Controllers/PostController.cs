using Dashboard.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Dashboard.Hosts.Api.Controllers
{
    /// <summary>
    /// Контроллер для работы с объявлениями.
    /// </summary>
    [ApiController]
    [Route("post")]
    public class PostController : ControllerBase
    {
        /// <summary>
        /// Возвращает объявление по идентификатору.
        /// </summary>
        /// <remarks>
        /// Пример:
        /// curl 
        /// </remarks>
        /// <param name="id">Идентификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель объявления <see cref="PostDto"/>.</returns>
        [HttpGet("get-by-id")]
        [ProducesResponseType(typeof(PostDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// Возвращает постраничные объявления.
        /// </summary>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <param name="pageSize">Размер страницы.</param>
        /// <param name="pageIndex">Номер страницы.</param>
        /// <returns>Коллекция объявлений <see cref="PostDto"/>.</returns>
        [HttpGet("get-all-paged")]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
        {
            return Ok();
        }

        /// <summary>
        /// Создаёт объявление.
        /// </summary>
        /// <param name="cancellationToken">Отмена операции.</param>
        [HttpPost]
        public async Task<IActionResult> CreateAsync(PostDto dto, CancellationToken cancellationToken)
        {
            return Created(string.Empty, null);
        }

        /// <summary>
        /// Редактирует объявления.
        /// </summary>
        /// <param name="cancellationToken">Отмена операции.</param>
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(PostDto dto, CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// Удаляет объявление по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
