using Design.Pattern.CreationalPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design.Pattern.Tests
{
    [TestClass]
    public class StructuralPatternsTests
    {
        [TestMethod]
        [TestCategory("StructualPattern")]
        public void AdapterTest()
        {

            //adapter pattern allows the interface of an existing class 
            //to be used as another interface.
            //it is often used to make existing classes work with others without
            //modifying their source code
            Switch lightSwitch = new Switch(new Ligh());
            lightSwitch.ApplySwitchsignal(true);
            lightSwitch.ApplySwitchsignal(false);

            Switch fanSwitch = new Switch(new Fan());
            fanSwitch.ApplySwitchsignal(true);
            fanSwitch.ApplySwitchsignal(false);


            Switch huaweiLightSwitch = new Switch(new HuaweiLightDelegateAdapter());
            huaweiLightSwitch.ApplySwitchsignal(true);
            huaweiLightSwitch.ApplySwitchsignal(false);

            Switch huaweiLightSwitch2 = new Switch(new HuaweiLightInheritAdapter());
            huaweiLightSwitch2.ApplySwitchsignal(true);
            huaweiLightSwitch2.ApplySwitchsignal(false);

        }

        [TestMethod]
        [TestCategory("StructualPattern")]
        
        public void BridgeTest()
        {
            //Separate an abstraction (Abstraction) from its implementation (Implementor) by putting them in separate class hierarchies.
            //Implement the Abstraction in terms of (by delegating to) an Implementor object.

            //Modem client
            IModem modem = new DialModemController(new HayesModem());
            modem.Dial();
            modem.Receive();
            modem.Send();
            modem.Receive();

            //Ded client
            IDedicatedodem dedicatedodem = new DedModemController(new USRoboticsModem());
            modem.Send();
            modem.Receive();
        }

        [TestMethod]
        [TestCategory("StructualPattern")]
        public void CompositeTest()
        {
        }

        [TestMethod]
        [TestCategory("StructualPattern")]
        public void DecoratorTest()
        {
        }

        [TestMethod]
        [TestCategory("StructualPattern")]
        public void FacadeTest()
        {
        }

        [TestMethod]
        [TestCategory("StructualPattern")]
        public void FlyweightTest()
        {
        }

        [TestMethod]
        [TestCategory("StructualPattern")]
        public void ProxyTest()
        {
        }


    }
}
