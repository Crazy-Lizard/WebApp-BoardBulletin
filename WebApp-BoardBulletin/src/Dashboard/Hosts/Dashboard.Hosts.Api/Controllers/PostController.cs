using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers
{
    /// <summary>
    /// Контроллер для работы с обьявлениями.
    /// </summary>
    public class PostController : ControllerBase
    {
        /// <summary>
        /// Возвращает обьявление по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор обьявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель обьявления <see cref="PostDto"/></returns>
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// Возвращает постраничные обьявления.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IActionResult> CreateAsync(CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IActionResult> UpdateAsync(CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
