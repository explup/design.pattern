using Design.Pattern.CreationalPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Design.Pattern.Tests
{
    [TestClass]
    public class BehavioralPatternsTest
    {
        [TestMethod]
        [TestCategory("BehavioralPatternsTest")]
        public void ChainOfResponsibilityTest()
        {
        }

        [TestMethod]
        [TestCategory("BehavioralPatternsTest")]
        public void CommandTest()
        {
            ICommand cluthonCommand = new ClutchOnCommand();
            cluthonCommand.Do();

            ICommand motorCommand = new MetorOnCommand();
            motorCommand.Do();


            //example2
            ITransaction transaction = new AddEmployeeTransaction(new SalariedClassification());
            transaction.Validate();
            transaction.Execute(); 
        }

        [TestMethod]
        [TestCategory("BehavioralPatternsTest")]
        public void InterpreterTest()
        {
        }

        [TestMethod]
        [TestCategory("BehavioralPatternsTest")]
        public void MediatorTest()
        {
        }

        [TestMethod]
        [TestCategory("BehavioralPatternsTest")]
        public void ObserverTest()
        {
        }

        [TestMethod]
        [TestCategory("BehavioralPatternsTest")]
        public void StateTest()
        {
        }

        [TestMethod]
        [TestCategory("BehavioralPatternsTest")]
        public void TemplateMethodTest()
        {
        }

        [TestMethod]
        [TestCategory("BehavioralPatternsTest")]
        public void VisitorTestq()
        {
        }

    }
}
