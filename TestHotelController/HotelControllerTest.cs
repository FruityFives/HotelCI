using HotelWebAPI.Controllers;
using HotelWebAPI.Data;
using HotelWebAPI.Interfaces;
using HotelWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

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

            // Act


            // arrange



            // Assert

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
            // Arrange
            var repository = new HotelRepository();  // Using the real repository
            var controller = new HotelsController(repository);  // Passing the repository to the controller

            var newHotel = new Hotel { HotelId = 5, Name = "New Hotel" };  // Create a new hotel object

            // Act
            var result = controller.Post(newHotel) as CreatedAtActionResult;  // Call the Post method of the controller

            // Assert
            Assert.IsNotNull(result);  // Ensure the result is not null
            Assert.AreEqual("Get", result.ActionName);  // Ensure the ActionName is "Get", indicating that it redirects to the Get method
            Assert.AreEqual(newHotel.HotelId, ((Hotel)result.Value).HotelId);  // Ensure the returned hotel's ID is the same as the one we passed
            Assert.AreEqual(newHotel.Name, ((Hotel)result.Value).Name);  // Ensure the returned hotel's Name is the same as the one we passed
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