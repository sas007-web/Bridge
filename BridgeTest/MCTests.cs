using Bridge;
namespace MCTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void MCPriceTest()
        {
            MC mc = new MC();

            Assert.AreEqual(120, mc.Price()); //Asserting(testing) that the price of the MC is 130

        }

        [TestMethod]
        public void MCVehicleTypeTest()
        {
            var mc = new MC();

            Assert.AreEqual("MC", mc.VehicleType()); //Asserting(testing) that the vehicle type is MC
        }


    }

}
