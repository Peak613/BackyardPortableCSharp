﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackyardPortableCSharp.Models
{
    // Models returned by MeController actions.
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}