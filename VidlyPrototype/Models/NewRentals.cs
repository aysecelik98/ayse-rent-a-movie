﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyPrototype.Models
{
    public class NewRentals
    {
        public int Id { get; set; }

        [Required]
        public Movie Movie { get; set; }

        [Required(ErrorMessageResourceName = "customer_required", ErrorMessageResourceType = typeof(Resources.Controller_Rentals_Form))]
        public Customer Customer { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}