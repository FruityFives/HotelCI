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


// Arrange (Forberedelse)
        var repository = new HotelRepository(); // Opret en instans af HotelRepository (den rigtige repository med hardcodet data)
        var controller = new HotelsController(repository); // Opret en instans af HotelsController og send repository med

        // Act (Handling)
        var result = controller.Get(); // Kald Get-metoden på controlleren

        // Assert (Verifikation)
        var okResult = result as OkObjectResult; // Cast resultatet til OkObjectResult
        Assert.IsNotNull(okResult); // Bekræft at resultatet ikke er null

        var returnedHotels = okResult.Value as List<Hotel>; // Cast værdien til List<Hotel>
        Assert.IsNotNull(returnedHotels); // Bekræft at den returnerede data ikke er null

        // Bekræft at antallet af returnerede hoteller matcher forventningen (4 i dette tilfælde)
        Assert.AreEqual(4, returnedHotels.Count); // Antag at repository indeholder 4 hoteller
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

    // Manuelt tilføj en fejl til ModelState, så den bliver invalid
    _controller.ModelState.AddModelError("Name", "Name is required");

    // Act
    var result = _controller.Post(invalidHotel) as BadRequestObjectResult;

    // Assert
    Assert.IsNotNull(result); // Sørger for, at resultatet ikke er null
    Assert.AreEqual(400, result.StatusCode); // Bekræfter, at statuskoden er 400
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

            // Arrange
            var repository = new HotelRepository(); // Antager, at du har en HotelRepository
            var controller = new HotelsController(repository); // Opret controller med repository
            var newHotel = new Hotel { HotelId = 1, Name = "Test Hotel" };
            // Act
            var result = controller.Post(newHotel) as CreatedAtActionResult; // Kalder Post-metoden på controlleren

            // Assert
            Assert.IsNotNull(result); // Bekræft, at resultatet ikke er null
            Assert.AreEqual("Get", result.ActionName); // Bekræft, at ActionName er "Get"
            Assert.IsNotNull(result.Value); // Bekræft, at result.Value ikke er null

            var createdHotel = result.Value as Hotel; // Cast result.Value til Hotel
            Assert.IsNotNull(createdHotel); // Bekræft, at castet er succesfuldt
            Assert.AreEqual(newHotel.HotelId, createdHotel.HotelId); // Bekræft, at HotelId matcher
            Assert.AreEqual(newHotel.Name, createdHotel.Name); // Bekræft, at Name matcher
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