﻿using System;
using System.Collections.Generic;

namespace Cocomix_API.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? ProductId { get; set; }
        public int? OrderId { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}