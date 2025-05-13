using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using User.Services;

namespace Test.UnitTests1
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

        // === AddUser Tests ===

        [TestMethod]
        public void AddUser_ValidUser_AddsToList()
        {
            // Add two users
            _service.AddUser("Khoi", "khoi@example.com");
            _service.AddUser("Hoang", "Hoang@example.com");

            // The users should be added in order
            Assert.AreEqual(2, _service.Users.Count);
            Assert.AreEqual("Khoi", _service.Users[0].Name);
            Assert.AreEqual("Hoang", _service.Users[1].Name);
        }

        [TestMethod]
        public void AddUser_DuplicateName_ThrowsException()
        {
            // Add one user
            _service.AddUser("Khoi", "khoi@example.com");

            // Adding a user with the same name should throw an exception
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                _service.AddUser("Khoi", "another@example.com");
            });
        }

        [TestMethod]
        public void AddUser_EmptyNameOrEmail_ThrowsException()
        {
            // Empty name should throw an ArgumentException
            Assert.ThrowsException<ArgumentException>(() =>
            {
                _service.AddUser("", "email@example.com");
            });

            // Empty email should also throw an ArgumentException
            Assert.ThrowsException<ArgumentException>(() =>
            {
                _service.AddUser("Name", "");
            });
        }
    }
}
