using Dashboard.Domain.Attachment;
using Dashboard.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Domain.Posts
{
    /// <summary>
    /// Сущность объявлений.
    /// </summary>
    public class Post : BaseEntity
    {
        /// <summary>
        /// Заголовок.
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public required string Description { get; set; }

        /// <summary>
        /// Наименование категории.
        /// </summary>
        public required Guid CategoryId { get; set; }

        /// <summary>
        /// Наименование тегов.
        /// </summary>
        public string[] TagNames { get; set; }

        /// <summary>
        /// Изображения.
        /// </summary>
        public required IReadOnlyCollection<AttachmentDto> Attachments { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public required decimal Price { get; set; }
    }
}