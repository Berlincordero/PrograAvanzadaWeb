using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class MediaComponent
{
    public int ComponentId { get; set; }

    public string ComponentName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<MediaContent> MediaContents { get; set; } = new List<MediaContent>();
}
