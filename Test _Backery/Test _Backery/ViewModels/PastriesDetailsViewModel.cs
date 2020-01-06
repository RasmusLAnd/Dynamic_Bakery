using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test__Backery.Models;

namespace Test__Backery.ViewModels
{
    public class PastriesDetailsViewModel
    {
        public Pastries Pastries { get; set; }
        public IEnumerable<Review> PastriesReviews { get; set; }
    }
}
