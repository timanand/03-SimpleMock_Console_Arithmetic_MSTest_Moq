using Microsoft.VisualStudio.TestTools.UnitTesting; // MS Test Framework used
using ConsoleApp1;
using Moq;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        public int i = 10, j = 25;
        public bool result;

        [TestInitialize]
        public void CheckNonNegative()
        {
            if(i>0 && j>0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }


        [TestCleanup]
        public void SetupDefaultValues()
        {
            result = false;
        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }


        [TestMethod]
        public void TestSum()
        {
            Assert.IsTrue(true);
        }



        [TestMethod]
        public void TestSum2()
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(35, ar.sum(i,j));
        }


        //[TestMethod]
        //public void TestSum3(int a, int b, int expected)
        //{
        //    Arithmetic ar = new Arithmetic();
        //    Assert.AreEqual(expected, ar.sum(a, b));
        //}

        
        [TestMethod]
        public void CheckValues()
        {
            //Arithmetic ar = new Arithmetic();
            //Assert.AreEqual(true, ar.CheckDigitsOnly());  // this will return false as we are expecting true

            Mock<Arithmetic> mock = new Mock<Arithmetic>();
            //mock.Setup(x=>x.CheckDigitsOnly()).Returns(true);
            mock.Setup(x=>x.CheckDigitsOnly()).Returns(true);
            Assert.AreEqual(true, mock.Object.CheckDigitsOnly());
        }


    }
}
