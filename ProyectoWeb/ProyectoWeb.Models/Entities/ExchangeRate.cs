using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models.Entities;

public partial class ExchangeRate
{
    public int RateId { get; set; }

    public string Currency { get; set; } = null!;

    public decimal ExchangeRate1 { get; set; }

    public DateTime Date { get; set; }

    public virtual ICollection<ComponentExchangeRate> ComponentExchangeRates { get; set; } = new List<ComponentExchangeRate>();
}
