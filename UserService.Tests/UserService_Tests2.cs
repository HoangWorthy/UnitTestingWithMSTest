using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using User.Services;

namespace Test.UnitTests2
{
    [TestClass]
    public class UserServiceTests
    {
        private UserService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new UserService();
        }
        // === FindUserByName Tests ===

        [TestMethod]
        public void FindUserByName_ExistingUser_ReturnsUser()
        {
            _service.AddUser("Hoang", "hoang@example.com");

            var user = _service.FindUserByName("Hoang");

            Assert.IsNotNull(user);
            Assert.AreEqual("hoang@example.com", user!.Email);
        }

        [TestMethod]
        public void FindUserByName_NonExistentUser_ReturnsNull()
        {
            var user = _service.FindUserByName("NonExistent");

            Assert.IsNull(user);
        }
    }
}
