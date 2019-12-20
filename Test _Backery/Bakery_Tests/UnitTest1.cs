using Moq;
using System;
using Test__Backery.Models;
using Test__Pasteries.Models.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Test__Backery.ViewModels;
using System.Linq;

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
            var mockCatRepo = new Mock<ICategoryRepository>();

            //Act           
            var pastriesController = new PastriesController(mockPastriesRepo.Object, mockCatRepo.Object);
            var result = pastriesController.List();
            
            //Assert            
            Assert.IsType<ViewResult>(result);
            
        }
        
        [Fact]
        public void MyTestTwo()
        {   // 

            //Arrange
            var myPastriesRepository = new Mock<PastriesRepository>();

            myPastriesRepository.GetPastriesById();
            

            //Assert



        }

    }

}
