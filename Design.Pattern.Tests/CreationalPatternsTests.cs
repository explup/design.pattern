using Design.Pattern.CreationalPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design.Pattern.Tests
{
    [TestClass]
    public class DesignPatternTests
    {
        [TestMethod]
        [TestCategory("CreationalPatterns")]
        public void AbstractFactoryTest()
        {
        }

        [TestMethod]
        [TestCategory("CreationalPatterns")]
        public void BuilderTest()
        {
            VehicleBuilder builder = new VehicleBuilder();
            Vehicle vehicle = builder.AddLicensePlate("Lic")
                                     .AddMark("mark")
                                     .ToVehicle();

            Assert.AreEqual("Lic", vehicle.LicensePlate);
            Assert.AreEqual("mark", vehicle.Mark);

        }

        [TestMethod]
        [TestCategory("CreationalPatterns")]
        public void FactoryMethodTest()
        {
            IProductFactory factory = new ProductFactoryImpl();
            IProduct computer = factory.CreateProduct("Computer");
            Assert.AreEqual(0.02M, computer.GetTaxPercentage());

            IProduct food = factory.CreateProduct("Food");
            Assert.AreEqual(0.01M, food.GetTaxPercentage());
        }

        [TestMethod]
        [TestCategory("CreationalPatterns")]
        public void PrototypeTest()
        {
        }

        [TestMethod]
        [TestCategory("CreationalPatterns")]
        public void SingletonTest()
        {
        }
    }
}
