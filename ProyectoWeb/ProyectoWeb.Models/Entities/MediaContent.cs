using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class MediaContent
{
    public int ContentId { get; set; }

    public int ComponentId { get; set; }

    public string ContentType { get; set; } = null!;

    public string? ContentUrl { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? PublishedDate { get; set; }

    public virtual MediaComponent Component { get; set; } = null!;
}
