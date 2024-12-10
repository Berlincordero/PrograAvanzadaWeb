using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class ComponentExchangeRate
{
    public int ComponentExchangeId { get; set; }

    public int ComponentId { get; set; }

    public int RateId { get; set; }

    public virtual MediaComponent Component { get; set; } = null!;

    public virtual ExchangeRate Rate { get; set; } = null!;
}
