using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarTests
{
    /// <summary>
    /// Contains unit tests for the Car class.
    /// </summary>
    [TestClass]
    public class CarTests
    {
        /// <summary>
        /// Tests that the Price method returns 230 when no Brobizz discount is applied.
        /// </summary>
        [TestMethod]
        public void CarPriceTest()
        {
            var car = new Car("ABC123", DateTime.Now, false);
            Assert.AreEqual(230, car.Price());
        }

        /// <summary>
        /// Tests that the VehicleType method returns "Car".
        /// </summary>
        [TestMethod]
        public void CarVehicleTypeTest()
        {
            var car = new Car("ABC123", DateTime.Now, false);
            Assert.AreEqual("Car", car.VehicleType());
        }

        /// <summary>
        /// Tests that the default constructor still creates a Car with the correct vehicle type.
        /// </summary>
        [TestMethod]
        public void CarLicensePlateTest()
        {
            var car = new Car();
            Assert.AreEqual("Car", car.VehicleType());
        }

        /// <summary>
        /// Tests that an ArgumentException is thrown when the license plate is longer than 7 characters.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "License plate cannot be longer than 7 characters.")]
        public void CarLicensePlateTooLongTest()
        {
            var car = new Car("12345678", DateTime.Now, false);
        }

        /// <summary>
        /// Tests that a valid license plate (7 characters) is correctly assigned.
        /// </summary>
        [TestMethod]
        public void CarLicensePlateValidTest()
        {
            var car = new Car("1234567", DateTime.Now, false);
            Assert.AreEqual("1234567", car.LicensePlate);
        }

        /// <summary>
        /// Tests that the Price method applies a 10% discount when a Brobizz is used.
        /// </summary>
        [TestMethod]
        public void CarPrice_WithBrobizz_ReturnsDiscountedPrice()
        {
            // Arrange
            var car = new Car("ABC123", DateTime.Now, true);
            double expectedPrice = 230 * 0.9;

            // Act
            double actualPrice = car.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.001);
        }
    }
}
