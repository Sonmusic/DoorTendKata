using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnTrue_Open_ClosedAndUnlocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.ClosedAndUnlocked("123");
            door.Open();
            Assert.IsTrue(door.IsOpen());
        }
    }
}
