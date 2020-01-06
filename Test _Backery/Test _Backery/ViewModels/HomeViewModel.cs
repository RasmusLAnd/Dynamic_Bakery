using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test__Backery.Models;

namespace Test__Backery.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pastries> PastriesList { get; set; }
        public IEnumerable<Review> ReviewList { get; set; }
        // implementer din ReviewList fra Homecontroller.
    }
}
