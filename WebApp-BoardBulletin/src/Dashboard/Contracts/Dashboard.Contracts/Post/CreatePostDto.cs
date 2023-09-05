using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Contracts.Post
{
    public class CreatePostDto
    {
        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Наименование тегов.
        /// </summary>
        public string[] TagNames { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public decimal Price { get; set; }
    }
}
