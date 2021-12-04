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
        public void ReturnFalse_Close_ClosedAndUnlocked_Door()
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
        [TestMethod]
        public void ReturnTrue_Lock_OpenAndUnlocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.OpenAndUnlocked("123");
            door.Lock();
            Assert.IsTrue(door.IsLocked());
        }
        [TestMethod]
        public void ReturnTrue_Unlock_OpenAndLocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.OpenAndLocked("123");
            if (door.Key == "123")
            {
                door.Unlock();
                Assert.IsTrue(door.IsUnlocked());
            }
            else
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void ReturnFalse_Unlock_OpenAndLocked_Door_WrongKey()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.OpenAndLocked("123");
            if (door.Key == "321")
            {
                Assert.Fail();
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void ReturnFalse_Unlock_CosedAndUnLocked_Door()
        {
            KataDoor.Door door = new KataDoor.Door();
            door.ClosedAndUnlocked("123");
            try
            {
                if (door.Key == "123")
                {
                    door.Unlock();
                    Assert.Fail();
                }
                else
                {
                    Assert.Fail();
                }
            }
            catch (System.Exception)
            {
                Assert.IsTrue(door.IsUnlocked());
            }

        }
    }
}
