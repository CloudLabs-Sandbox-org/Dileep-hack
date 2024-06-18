using NUnit.Framework;
using System.Collections.Generic;
using System.Web.Mvc;
using CRUD_application_2.Controllers;
using CRUD_application_2.Models;
//using Microsoft.AspNetCore.Mvc
using Moq;

namespace CRUD_application_2.Tests.Controllers
{
    [TestFixture]
    public class UserControllerTests : IDisposable
    {
        private UserController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new UserController();
            UserController.userlist = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane Doe", Email = "jane@example.com" }
            };
        }
        [TearDown]
        public void TearDown()
        {
            Dispose();
        }

        public void Dispose()
        {
            // Dispose of your controller here if it holds unmanaged resources
            _controller?.Dispose();
            // Note: Only necessary if UserController implements IDisposable.
            // If UserController does not implement IDisposable, you can remove this line.
        }

        //[Test]
        //public void Index_ReturnsViewWithAllUsers()
        //{
        //    // Act
        //    var result = _controller.Index() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result, "Result should not be null.");
        //    Assert.IsNotNull(result.Model, "Model should not be null.");

        //    // Safe cast to List<User> and ensure it's not null before accessing Count
        //    var model = result.Model as List<User>;
        //    Assert.That(model, Is.Not.Null, "Model should be of type List<User>.");

        //    // Use the constraint model for the assertion
        //    Assert.That(model.Count, Is.EqualTo(2), "Model count should be 2.");
        //}


        //[Test]
        //public void Details_WithValidId_ReturnsUser()
        //{
        //    // Act
        //    var result = _controller.Details(1) as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result, "Result should not be null.");
        //    Assert.IsNotNull(result.Model, "Model should not be null.");

        //    // Safe cast to User and ensure it's not null before accessing Id
        //    var model = result.Model as User;
        //    Assert.IsNotNull(model, "Model should be of type User.");

        //    // Use the constraint model for the assertion
        //    Assert.That(model.Id, Is.EqualTo(1), "Model Id should be 1.");
        //}


        [Test]
        public void Details_WithInvalidId_ReturnsHttpNotFound()
        {
            var result = _controller.Details(999) as HttpNotFoundResult;
            Assert.IsNotNull(result);
        }

        //[Test]
        //public void Create_Get_ReturnsView()
        //{
        //    var result = _controller.Create() as ViewResult;
        //    Assert.IsNotNull(result);
        //}

        //[Test]
        //public void Create_Post_ValidUser_RedirectsToIndex()
        //{
        //    var newUser = new User { Id = 3, Name = "New User", Email = "new@example.com" };
        //    var result = _controller.Create(newUser) as RedirectToRouteResult;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Index", result.RouteValues["action"]);
        //}

        //[Test]
        //public void Edit_Get_WithValidId_ReturnsViewWithUser()
        //{
        //    var result = _controller.Edit(1) as ViewResult;
        //    Assert.IsNotNull(result, "Result should not be null.");

        //    // Ensure the model is not null before accessing its properties
        //    var model = result.Model as User;
        //    Assert.IsNotNull(model, "Model should not be null.");

        //    // Use the constraint model for the assertion
        //    Assert.That(model.Id, Is.EqualTo(1), "Model Id should be 1.");
        //}


        [Test]
        public void Edit_Get_WithInvalidId_ReturnsHttpNotFound()
        {
            var result = _controller.Edit(999) as HttpNotFoundResult;
            Assert.IsNotNull(result);
        }

        //[Test]
        //public void Edit_Post_WithValidData_RedirectsToIndex()
        //{
        //    var updatedUser = new User { Id = 1, Name = "Updated User", Email = "updated@example.com" };
        //    var result = _controller.Edit(1, updatedUser) as RedirectToRouteResult;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Index", result.RouteValues["action"]);
        //}

        //[Test]
        //public void Delete_Get_WithValidId_ReturnsViewWithUser()
        //{
        //    var result = _controller.Delete(1) as ViewResult;
        //    Assert.IsNotNull(result);
        //    var model = result.Model as User;
        //    Assert.AreEqual(1, model.Id);
        //}

        [Test]
        public void Delete_Get_WithInvalidId_ReturnsHttpNotFound()
        {
            var result = _controller.Delete(999) as HttpNotFoundResult;
            Assert.IsNotNull(result);
        }

        //[Test]
        //public void Delete_Post_WithValidId_RedirectsToIndex()
        //{
        //    var result = _controller.Delete(1, new FormCollection()) as RedirectToRouteResult;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Index", result.RouteValues["action"]);
        //}
    }
}
