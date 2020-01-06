using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test__Backery.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test__Backery.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepository;
        private Review _FormFeed;

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        // GET: /<controller>/
        public IActionResult ReviewLook(int id)
        {
            ViewBag.PastriesId = id;
            return View();
        }

        [HttpPost]
        public IActionResult ReviewLook(Review review)
        {
            _FormFeed = review;

            if (ModelState.IsValid)
            {
                _reviewRepository.CreateReview(review);
                return RedirectToAction("ReviewCreated");
            }
            return View();
        }

        public IActionResult ReviewCreated()
        {
            ViewBag.ReviewCompleteMessage = "Thanks";
            return View();
        }
        
    }
}
