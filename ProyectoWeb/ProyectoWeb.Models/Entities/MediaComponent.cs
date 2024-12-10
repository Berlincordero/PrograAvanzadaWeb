using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class MediaComponent
{
    public int ComponentId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ComponentExchangeRate> ComponentExchangeRates { get; set; } = new List<ComponentExchangeRate>();

    public virtual ICollection<ComponentWeather> ComponentWeathers { get; set; } = new List<ComponentWeather>();

    public virtual ICollection<MediaContent> MediaContents { get; set; } = new List<MediaContent>();
}
