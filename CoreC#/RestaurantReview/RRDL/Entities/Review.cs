﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Review
    {
        public int Id { get; set; }
        public int? RestaurantId { get; set; }
        public decimal? Rating { get; set; }
        public string Description { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
