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
            // Add a user so we can later find them
            _service.AddUser("Hoang", "hoang@example.com");

            // Try to find the user by name
            var user = _service.FindUserByName("Hoang");

            // Verify that a user was found and the email is correct
            Assert.IsNotNull(user);
            Assert.AreEqual("hoang@example.com", user!.Email);
        }

        [TestMethod]
        public void FindUserByName_NonExistentUser_ReturnsNull()
        {
            // Try to find a user that doesn't exist
            var user = _service.FindUserByName("NonExistent");

            // Make sure the result is null since the user was never added
            Assert.IsNull(user);
        }
    }
}
