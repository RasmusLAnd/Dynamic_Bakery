
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Test__Backery.Models;
using Test__Backery.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test__Pasteries.Models.Controllers
{
    public class PastriesController : Controller
    {
        private readonly IPastriesRepository _pastriesRepository;
        private readonly IReviewRepository _reviewRepository;


        

        public PastriesController(IPastriesRepository pasteriesRepository, ICategoryRepository categoryRepository, IReviewRepository reviewRepository)
            {
            _pastriesRepository = pasteriesRepository;
            _reviewRepository = reviewRepository;
            }

        public ViewResult List()
        {
            PastriesListViewModel pasteriesListViewModel = new PastriesListViewModel
            {
                Pastries = _pastriesRepository.AllPastries
               

            };
            return View(pasteriesListViewModel);
        }
        


    }
}
