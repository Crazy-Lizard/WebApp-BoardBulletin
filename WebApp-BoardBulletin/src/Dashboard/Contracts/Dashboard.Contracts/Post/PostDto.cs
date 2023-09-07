using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Contracts
{

    /// <summary>
    /// Объявление. 
    /// </summary>
    public class PostDto : BaseDto
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
        public required string CategoryName { get; set; }

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