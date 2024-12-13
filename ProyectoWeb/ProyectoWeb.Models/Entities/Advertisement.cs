using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class Advertisement
{
    public int AdId { get; set; }

    public string Title { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public string? TargetUrl { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
