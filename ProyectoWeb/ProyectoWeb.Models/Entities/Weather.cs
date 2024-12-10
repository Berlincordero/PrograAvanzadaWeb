using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class Weather
{
    public int WeatherId { get; set; }

    public string City { get; set; } = null!;

    public double Temperature { get; set; }

    public string Condition { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual ICollection<ComponentWeather> ComponentWeathers { get; set; } = new List<ComponentWeather>();
}
