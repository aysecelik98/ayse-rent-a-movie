using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyPrototype.Dtos
{
    public class NewRentalsDto
    {
        [Required(ErrorMessageResourceName = "customer_required", ErrorMessageResourceType = typeof(Resources.Controller_Rentals_Form))]
        public int CustomerId { get; set; }

        public List<int> MovieIds { get; set; }
    }
}