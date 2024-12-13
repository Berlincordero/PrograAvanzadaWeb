using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Data
{
    public class MediaContentDTO
    {
        public int ContentId { get; set; }
        public int ComponentId { get; set; }
        public string ContentType { get; set; } = null!;
        public string? ContentUrl { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}