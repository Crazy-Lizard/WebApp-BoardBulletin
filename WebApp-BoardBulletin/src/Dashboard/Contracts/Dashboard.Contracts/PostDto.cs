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
    /// Обьявление. 
    /// </summary>
    internal class PostDto : BaseDto
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
        /// Наименование категории.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Наименование тегов.
        /// </summary>
        public string[] TagNames { get; set; }

        /// <summary>
        /// Изображения.
        /// </summary>
        IReadOnlyCollection<AttachmentDto> Attachments { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public decimal Price { get; set; }
    }
}