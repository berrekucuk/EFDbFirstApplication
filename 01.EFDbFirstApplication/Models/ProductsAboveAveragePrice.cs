﻿using System;
using System.Collections.Generic;

namespace _01.EFDbFirstApplication.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
