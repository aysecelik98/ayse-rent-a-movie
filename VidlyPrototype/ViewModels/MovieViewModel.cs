﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyPrototype.Models;

namespace VidlyPrototype.ViewModels
{
    public class MovieViewModel
    {
        public List<MovieGenres> MovieGenres { get; set; }
        public Movie Movies { get; set; }
    }
}