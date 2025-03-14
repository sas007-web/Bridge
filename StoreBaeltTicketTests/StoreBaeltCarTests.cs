using StoreBaeltTicketLibrary;
namespace StoreBaeltTicketTests
{
    [TestClass]
    public sealed class StoreBaeltCarTests
    {
        [TestMethod]
        public void Price_ReturnsBasePrice_OnWeekdayWithoutBrobizz()
        {
            //Arrange: put a car on weekday without Brobizz discount
            DateTime monday = new DateTime(2025, 03, 10); //Monday
            var car = new StoreBaeltCar("AB12345", monday, false);

            //Act: Call th price method
            double price = car.Price();

          //Assert: check if the price is as expected. 
          double expectedPrice = 230; //Base price on weekday without Brobizz
            Assert.AreEqual(expectedPrice, price, 0.01);
        }

        [TestMethod]
        public void Price_WeekendDiscount_OnWeekendWithoutBrobizz()
        {
            // Arrange: Set up a car on a weekend (Saturday) without a Brobizz discount.
            DateTime saturday = new DateTime(2025, 4, 26); // Saturday
            var car = new StoreBaeltCar("AB12345", saturday, false);

            // Act: Call the Price method.
            double actualPrice = car.Price();

            // Assert: Expected price = 230 * 0.85 (15% discount on weekends)
            double expectedPrice = 230 * 0.85;
            Assert.AreEqual(expectedPrice, actualPrice, 0.01);
        }

        [TestMethod]
        public void Price_AppliesBrobizzDiscount_OnWeekdayWithBrobizz()
        {
            // Arrange: Set up a car on a weekday (Monday) with Brobizz.
            DateTime monday = new DateTime(2025, 4, 21); // Monday
            var car = new StoreBaeltCar("AB12345", monday, true);

          //Act: Call the Price method.
          double actualPrice = car.Price();

            //Assert: Expected price = 230 * 0.9 (10% discount with Brobizz)
            double expectedPrice = 230 * 0.9; // 207
            Assert.AreEqual(expectedPrice, actualPrice, 0.01, "The price should have a 10% Brobizz discount on a weekday.");
        }

        [TestMethod]
        public void Price_AppliesBothDiscounts_OnWeekendWithBrobizz()
        {
            //Arrange : Set up a car on a weekend (Sunday) with Brobizz.
            DateTime sunday = new DateTime(2025, 4, 27); // Sunday
            var car = new StoreBaeltCar("AB12345", sunday, true);

            //Act: Call the Price method.
            double actualPrice = car.Price();

            //Assert: Expected price = 230 * 0.85 * 0.9 (15% weekend discount and 10% Brobizz discount)
            double expectedPrice = 230 * 0.85 * 0.9; // 175.95
            Assert.AreEqual(expectedPrice, actualPrice, 0.01, "The price should have a 15% weekend discount and a 10% Brobizz discount.");
        }

    }

}
