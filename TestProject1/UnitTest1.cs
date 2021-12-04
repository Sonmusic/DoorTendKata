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

        [TestMethod]
        public void ReturnFalse_Open_ClosedAndLocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.ClosedAndLocked("123");
            try
            {
                door.Open();
                Assert.Fail();
            }
            catch (System.Exception)
            {
                Assert.IsFalse(door.IsOpen());
            }
        }

        [TestMethod]
        public void ReturnFalse_Open_OpenAndUnlocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.OpenAndUnlocked("123");
            try
            {
                door.Open();
                Assert.Fail();
            }
            catch (System.Exception)
            {
                Assert.IsTrue(door.IsOpen());
            }
        }

        [TestMethod]
        public void ReturnFalse_Open_OpenAndLocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.OpenAndLocked("123");
            try
            {
                door.Open();
                Assert.Fail();
            }
            catch (System.Exception)
            {
                Assert.IsTrue(door.IsOpen());
            }
        }
        [TestMethod]
        public void ReturnTrue_Close_OpenAndUnlocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.OpenAndUnlocked("123");
            door.Close();
            Assert.IsTrue(door.IsClosed());
        }
        [TestMethod]
        public void ReturnFalse_Close_CloedAndUnlocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.ClosedAndUnlocked("123");
            try
            {
                door.Close();
                Assert.Fail();
            }
            catch (System.Exception)
            {
                Assert.IsTrue(door.IsClosed());
            }
        }

    }
}
