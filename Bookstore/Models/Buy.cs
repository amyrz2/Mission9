using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Bookstore.Models
{
    public class Buy
    {
        [Key]
        [BindNever]

        public int BuyId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please eneter a name: ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please eneter the first address line")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please eneter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please eneter a state")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Please eneter a country")]
        public string Country { get; set; }
    }
}

