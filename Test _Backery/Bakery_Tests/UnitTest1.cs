using Moq;
using System;
using Test__Backery.Models;
using Test__Pasteries.Models.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Test__Backery.ViewModels;
using System.Linq;
using GenFu;
using Test__Backery.Controllers;

namespace Bakery_Tests
{
    public class UnitTest1
    {      
        
        [Fact]
        public void MyTestOne()
        {
            //testing if the pastriesController returns a ViewResult

            //Arrange  

            var mockPastriesRepo = new Mock<IPastriesRepository>();
            var mockCategoryRepo = new Mock<ICategoryRepository>();
            var mockReviewRepo = new Mock<IReviewRepository>();

            //Act           
            var pastriesController = new PastriesController(mockPastriesRepo.Object, mockCategoryRepo.Object, mockReviewRepo.Object);
            var result = pastriesController.List();
            
            //Assert            
            Assert.IsType<ViewResult>(result);
            
        }

        private IEnumerable<Pastries> GetFakeData()
            {
                var i = 1;
                var cakes = A.ListOf<Pastries>(26);
                cakes.ForEach(x => x.PastriesId = i++);
                return cakes.Select(_ => _);
            }

        /*[Fact]
        public void MyTestTwo()
        {   //Arrange 
            var mockPastriesRepo = new Mock<IPastriesRepository>();
            var mockCatRepo = new Mock<ICategoryRepository>();

            
            var myPastriesRepository = new Mock<IPastriesRepository>();
            var cakes = GetFakeData();
            var firstCake = cakes.First();
            myPastriesRepository.Setup(x => x.GetPastriesById(1)).Returns(firstCake);

            var controller = new PastriesController(mockPastriesRepo.Object, mockCatRepo.Object);

            //Act
            var result = controller.List();

            //Assert
            
        }*/
        [Fact]
        public void SecondTest()
        {//Arrange  
            var mockPastriesRepo = new Mock<IPastriesRepository>();
            var mockReviewRepo = new Mock<IReviewRepository>();
         
            //Act           
              var homeController = new HomeController(mockPastriesRepo.Object, mockReviewRepo.Object);
            var data = homeController.Index();
            //Assert 
            Assert.IsType<ViewResult>(data);

        }

    }

}
