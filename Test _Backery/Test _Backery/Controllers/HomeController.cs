using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test__Backery.Models;
using Test__Backery.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test__Backery.Controllers
{
    public class HomeController : Controller

    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IPastriesRepository _pastriesRepository;

        public HomeController(IPastriesRepository pastriesRepository, IReviewRepository reviewRepository)
        {
            _pastriesRepository = pastriesRepository;
            _reviewRepository = reviewRepository;
        }
       
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PastriesList = _pastriesRepository.AllPastries,
                
                //For hver pie, loop reviewlist, hvis Id er ens, udskriv review.
                ReviewList = _reviewRepository.SelectedReviews
                
            };
            return View(homeViewModel);
        }
    }
}
