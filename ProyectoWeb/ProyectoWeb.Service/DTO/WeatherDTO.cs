using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.Data
{
    public class WeatherDTO
    {
        public int WeatherId { get; set; }
        public string City { get; set; } = null!;
        public float Temperature { get; set; }
        public string Condition { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}