using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MCTests
{
    /// <summary>
    /// Contains unit tests for the MC class.
    /// </summary>
    [TestClass]
    public class MCTests
    {
        /// <summary>
        /// Tests that the Price method returns 120 for an MC without Brobizz.
        /// </summary>
        [TestMethod]
        public void MCPriceTest()
        {
            MC mc = new MC(); // Creating a new MC object
            Assert.AreEqual(120, mc.Price()); // Asserting that the price of the MC is 120
        }

        /// <summary>
        /// Tests that the VehicleType method returns "MC" for an MC.
        /// </summary>
        [TestMethod]
        public void MCVehicleTypeTest()
        {
            var mc = new MC(); // Creating a new MC object
            Assert.AreEqual("MC", mc.VehicleType()); // Asserting that the vehicle type is MC
        }

        /// <summary>
        /// Tests that the Price method applies a 10% discount when Brobizz is used.
        /// </summary>
        [TestMethod]
        public void MCPrice_WithBrobizz_ReturnsDiscountedPrice()
        {
            // Arrange
            var mc = new MC("MC123", DateTime.Now, true); // Creating a new MC object with a license plate and a Brobizz
            double expectedPrice = 120 * 0.9; // 10% discount

            // Act
            double actualPrice = mc.Price(); // Getting the price of the MC

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.001); // Asserting that the price of the MC is the expected price
        }
    }
}
