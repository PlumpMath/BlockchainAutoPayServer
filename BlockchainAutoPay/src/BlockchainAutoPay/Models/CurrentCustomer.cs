﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlockchainAutoPay.Models
{
    public class CurrentCustomer
    {
        [Key]
        public string CustomerId { get; set; }
        public string Data { get; set; }
    }
}
