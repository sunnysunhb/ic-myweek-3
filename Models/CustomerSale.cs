using System;
using System.Collections.Generic;

namespace Week3EntityFramework.Models;

public partial class CustomerSale
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateSold { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }
}
