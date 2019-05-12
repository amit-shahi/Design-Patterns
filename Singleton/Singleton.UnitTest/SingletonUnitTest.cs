using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.UnitTest
{
    [TestClass]
    public class SingletonUnitTest
    {

        //[TestMethod] - UnComment if you want to see this TestMethod failed, not satisfying Singleton
        public void Should_Not_Return_Single_Instance_Of_Employee_With_Wrong_Approach()
        {

            Assert.AreEqual(WrongApproach.Instance, WrongApproach.Instance);
        }

        [TestMethod]
        public void Should_Return_Single_Instance_Of_Employee_Using_Popular_Approach()
        {
            
            Assert.AreEqual(PopularApproach.Instance, PopularApproach.Instance);
        }

        [TestMethod]
        public void Should_Return_Single_Instance_Of_Emplyee_Using_Quick_Approach()
        {

            Assert.AreEqual(QuickApproach.Instance, QuickApproach.Instance);

        }
    }
}
