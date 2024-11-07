using Microsoft.AspNetCore.Mvc;
using Moq;
using ValidateTheNameModelBinding.Models;
using ValidateTheNameWebApplication.Controllers;



namespace UnitTests.Controllers
{
    public class NameControllerTest
    {
            private readonly NameController _controller;
            //private readonly Mock<IPersonRepository> _mockRepository;

            public NameControllerTest()
            {
                //_mockRepository = new Mock<IPersonRepository>();
                _controller = new NameController();
            }

            [Fact]
            public void ValidateName_ValidModelState_ReturnsIndexView()
            {
                // Arrange
                var personDto = new PersonDTO { Firstname = "John", Lastname = "Doeee" };

                // Act
                var result = _controller.ValidateName(personDto) as ViewResult;

                // Assert
                Assert.NotNull(result);
                Assert.Equal("Index", result.ViewName);
        }
    }
}