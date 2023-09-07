using BulletinBoard.Contracts.Attributes;
using Dashboard.Contracts.Attachment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(150)]
        public string Description { get; set; }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        public required Guid CategoryId { get; set; }

        /// <summary>
        /// Наименование тегов.
        /// </summary>
        public required string[] TagNames { get; set; }

        /// <summary>
        /// Изображения.
        /// </summary>
        [Limit(1, 5)]
        public required IReadOnlyCollection<AttachmentDto> Attachments { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        [Range(0, double.MaxValue)]
        public required decimal Price { get; set; }
    }
}
