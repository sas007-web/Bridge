using Bridge;
namespace CarTests


{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CarPriceTest()
        {
            var car = new Car();

            Assert.AreEqual(230, car.Price()); //Asserting(testing) that the price of the car is 230

        }

        [TestMethod]
        public void CarVehicleTypeTest()
        {
            var car = new Car();

            Assert.AreEqual("Car", car.VehicleType()); //Asserting(testing) that the vehicle type is Car
        }
        [TestMethod]
        public void CarLicensePlateTest()
        {
            var car = new Car();
            Assert.AreEqual("Car", car.VehicleType()); //Asserting(testing) that the vehicle type is Car
        }
         

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "License plate cannot be longer than 7 characters.")]
        public void CarLicensePlateTooLongTest()
        {
            // This will throw an ArgumentException due to the license plate length
            var car = new Car("12345678", DateTime.Now); // License plate with more than 7 characters
        }

        [TestMethod]
        public void CarLicensePlateValidTest()
        {
            // This should work fine with a license plate of 7 characters
            var car = new Car("1234567", DateTime.Now);
            Assert.AreEqual("1234567", car.LicensePlate);
        }
    }
}
