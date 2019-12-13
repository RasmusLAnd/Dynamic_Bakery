using System.Collections.Generic;
using Test__Backery.Models;

namespace Test__Backery.ViewModels
{
    public class PastriesListViewModel
    {
        public IEnumerable<Pastries> Pastries { get; set; }
        public string CurrentCategory { get; set; }
    }
}
