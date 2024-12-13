using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Data
{
    public class NewsDTO
    {
        public int NewsId { get; set; }
        public string Title { get; set; } = null!;
        public string? Source { get; set; }
        public string? Url { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}