using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class News
{
    public int NewsId { get; set; }

    public string Title { get; set; } = null!;

    public string? Source { get; set; }

    public string? Url { get; set; }

    public DateTime PublishedDate { get; set; }
}
