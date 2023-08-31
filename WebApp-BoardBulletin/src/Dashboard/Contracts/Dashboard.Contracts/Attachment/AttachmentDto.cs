using Dashboard.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Contracts.Attachment
{
    /// <summary>
    /// Вложение.
    /// </summary>
    public class AttachmentDto : BaseDto
    {
        /// <summary>
        /// Содержимое вложения в виде массива байтов.
        /// </summary>
        public byte[] Content { get; init; }
    }
}
