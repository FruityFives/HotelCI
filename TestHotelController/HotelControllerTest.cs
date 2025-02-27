using HotelWebAPI.Controllers;
using HotelWebAPI.Data;
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
        var repository = new HotelRepository(); // Brug den faktiske repository-implementering
        var controller = new HotelsController(repository);
        int nonExistentId = 99; // Et ID, der ikke findes i listen

        // Act
        var result = controller.Remove(nonExistentId);

        // Assert
        Assert.IsInstanceOfType(result, typeof(NotFoundResult));
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