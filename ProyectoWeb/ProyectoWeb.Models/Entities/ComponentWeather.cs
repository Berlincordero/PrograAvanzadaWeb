using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class ComponentWeather
{
    public int ComponentWeatherId { get; set; }

    public int ComponentId { get; set; }

    public int WeatherId { get; set; }

    public virtual MediaComponent Component { get; set; } = null!;

    public virtual Weather Weather { get; set; } = null!;
}
