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
    // Arrange
    var testId = 1;
    
    // Act
    var result = _controller.Get(testId) as OkObjectResult;
    
    // Assert
    Assert.IsNotNull(result);
    Assert.AreEqual(200, result.StatusCode);

    var hotel = result.Value as Hotel;
    Assert.IsNotNull(hotel);
    Assert.AreEqual(testId, hotel.HotelId);
}




       [TestMethod]
public void Add_InvalidObjectPassed_ReturnsBadRequest()
{
    // Arrange
    var invalidHotel = new Hotel(); // Mangler obligatoriske felter som Name

    // Act
    var result = _controller.Post(invalidHotel) as BadRequestObjectResult;

    // Assert
    Assert.IsNotNull(result);
    Assert.AreEqual(400, result.StatusCode);
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