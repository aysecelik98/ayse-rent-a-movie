using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyPrototype.Models
{
    public class Rentals
    {
        public int Id { get; set; }

        //Relationships
        [Required]
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }

        [Required]
        public int MovieId { get; set; }
        public Movie Movies { get; set; }
        //End of Relationship
        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }

        public Rentals()
        {
            DateRented = DateTime.Now;
        }
    }
}