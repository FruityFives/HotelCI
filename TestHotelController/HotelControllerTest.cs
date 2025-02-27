using HotelWebAPI.Controllers;
using HotelWebAPI.Data;
using HotelWebAPI.Interfaces;
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
            int testId = 9999;


            // arrange
            var result = _controller.Get(testId);



            // Assert
             Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }


        [TestMethod]
        public void GetById_ExistingIdPassed_ReturnsOkResult()
        {

            // Arrange
            int existingId = 1; // Vi ved, at ID 1 eksisterer

            // Act
            var result = _controller.Get(existingId);

            // Assert
            Assert.AreEqual(typeof(OkObjectResult), result.GetType(), "Expected OkObjectResult but got a different response.");

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
        // Arrange
        var repository = new HotelRepository(); // Brug den rigtige repository-implementering
        var controller = new HotelsController(repository);
        int nonExistentId = 99; // Et ID, der ikke findes i listen

        // Act
        var result = controller.Remove(nonExistentId) as StatusCodeResult;

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(404, result.StatusCode); // 404 = NotFound
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