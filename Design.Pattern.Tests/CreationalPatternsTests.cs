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
