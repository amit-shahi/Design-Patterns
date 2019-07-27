using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.UnitTest
{
    [TestClass]
    public class SingletonUnitTest
    {

        [TestMethod] 
        public void Should_Not_Return_Single_Instance_Of_Employee_With_Wrong_Approach()
        {

            Assert.AreNotEqual(WrongApproach.Instance, WrongApproach.Instance);
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

        [TestMethod]
        public void Should_Return_Single_Instance_Of_Emplyee_Using_Lazy_Approach()
        {

            Assert.AreEqual(LazyApproach.Instance, LazyApproach.Instance);

        }
    }
}
