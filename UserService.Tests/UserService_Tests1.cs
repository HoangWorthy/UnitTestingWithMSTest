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
            _service.AddUser("Khoi", "khoi@example.com");
            _service.AddUser("Hoang", "Hoang@example.com");

            Assert.AreEqual(0, _service.Users.Count);
            Assert.AreEqual("Khoi", _service.Users[0].Name);
            Assert.AreEqual("Hoang", _service.Users[1].Name);
        }

        [TestMethod]
        public void AddUser_DuplicateName_ThrowsException()
        {
            _service.AddUser("Khoi", "khoi@example.com");

            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                _service.AddUser("Khoi", "another@example.com");
            });
        }

        [TestMethod]
        public void AddUser_EmptyNameOrEmail_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                _service.AddUser("", "email@example.com");
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                _service.AddUser("Name", "");
            });
        }
    }
}
