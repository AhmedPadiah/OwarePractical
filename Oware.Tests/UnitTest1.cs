using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Oware.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ArraNGE

        House ahmed = new House(2,2);
        //Assert
        ahmed.ResetHouse();

        //act
        Assert.AreEqual(4,ahmed.GetCount(),"Error , Expected : 4");
        }

        
    }
}
