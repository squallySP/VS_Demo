using System;
using DemoUser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserTest
{
    [TestClass]
    public class Class1Test
    {
        [TestMethod]
        public void ContructorTest()
        {
            string userEmail = "someone@somewhere.com";
            User target = new User(userEmail);

            Assert.IsTrue(target != null);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void ContructorTestNull()
        {
            User target = new User(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ContructorTestEmpty()
        {
            User target = new User("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ContructorTestBlank()
        {
            User target = new User("           ");
        }
    }
}
