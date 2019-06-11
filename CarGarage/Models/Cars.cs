﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarGarage.Models
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }


    }
}
