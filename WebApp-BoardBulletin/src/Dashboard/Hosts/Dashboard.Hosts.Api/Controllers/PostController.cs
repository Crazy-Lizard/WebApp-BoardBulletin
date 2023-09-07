using Dashboard.Application.AppServices.Contexts.Posts.Services;
using Dashboard.Contracts;
using Dashboard.Contracts.Post;
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
        private readonly IPostService _postService;

        /// <summary>
        /// Инициализирует экземпляр <see cref="PostController"/>
        /// </summary>
        /// <param name="postService">Сервис работы с объявлениями.</param>
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        /// <summary>
        /// Возвращает объявление по идентификатору.
        /// </summary>
        /// <remarks>
        /// Пример: curl -X 'GET' \'https://localhost:port/post/get-by-id'
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
            var result = await _postService.GetByIdAsync(id, cancellationToken);
            if (result == null)
                return NotFound(result);
            return Ok(result);
        }

        /// <summary>
        /// Возвращает постраничные объявления.
        /// </summary>
        /// <remarks>
        /// Пример: curl -X 'GET' \ 'https://localhost:port/post/get-all-by-pages?pageSize=10&amp;pageIndex=0'
        /// </remarks>
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
        /// <param name="dto">Модель для создания объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Идентификатор созданной сущности.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateAsync(CreatePostDto dto, CancellationToken cancellationToken)
        {
            var modelId = await _postService.CreateAsync(dto, cancellationToken);
            return Created(nameof(CreateAsync),modelId);
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
