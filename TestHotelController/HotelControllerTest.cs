using HotelWebAPI.Controllers;
using HotelWebAPI.Data;
using HotelWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using HotelWebAPI.Interfaces;


namespace TestHotelController
{
    [TestClass]
    public class HotelControllerTest
    {
        private readonly HotelsController _controller;
        private readonly IHotelRepository _repository;

        public HotelControllerTest()
        {
             _repository = new HotelRepository();
             _controller = new HotelsController(_repository);
        }


        [TestMethod]
        public void Get_WhenCalled_ReturnsOkResult()
        {

        // Arrange
        var repository = new HotelRepository();
        var controller = new HotelsController(repository);

        // Act
        var result = controller.Get();

        // Assert
        var okResult = result as OkObjectResult; // Cast the result to OkObjectResult
        Assert.IsNotNull(okResult); // Verify the result is not null
        var returnedHotels = okResult.Value as List<Hotel>; // Cast the value to List<Hotel>
        Assert.IsNotNull(returnedHotels); // Verify the returned data is not null
        Assert.AreEqual(4, returnedHotels.Count); // Verify the number of hotels returned

        }



        [TestMethod]
        public void Get_WhenCalled_ReturnsAllHotels()
        {


            // Act


            // arrange



            // Assert
        }

        [TestMethod]
        public void GetById_UnknownIdPassed_ReturnsNotFoundResult()
        {

            // Act


            // arrange



            // Assert
        }


        [TestMethod]
        public void GetById_ExistingIdPassed_ReturnsOkResult()
        {


            // Act


            // arrange



            // Assert

        }


        [TestMethod]
        public void GetById_ExistingIdPassed_ReturnsRightHotel()
        {

            // Act


            // arrange



            // Assert
        }



        [TestMethod]
        public void Add_InvalidObjectPassed_ReturnsBadRequest()
        {

            // Act


            // arrange



            // Assert
        }


        [TestMethod]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {

            // Act


            // arrange



            // Assert

        }



        [TestMethod]
        public void Add_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        {

            // Act


            // arrange



            // Assert
        }



        [TestMethod]
        public void Remove_NotExistingIdPassed_ReturnsNotFoundResponse()
        {

            // Act


            // arrange



            // Assert
        }


        [TestMethod]
        public void Remove_ExistingIdPassed_ReturnsNoContentResult()
        {

            // Act


            // arrange



            // Assert
        }
    }
}