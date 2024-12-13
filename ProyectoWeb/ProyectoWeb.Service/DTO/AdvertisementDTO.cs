using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Data
{

    public class AdvertisementDTO
    {
        public int AdId { get; set; }
        public string Title { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}