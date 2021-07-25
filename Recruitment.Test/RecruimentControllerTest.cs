using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Recruitment.API.Controllers;
using Recruitment.API.Infrastructure.Repository;
using Recruitment.Client.Models;

namespace Recruitment.Test
{

    [TestClass]
    public class RecruimentControllerTest
    {
        private readonly Mock<ICultureService> _mockRepo;
        private readonly ContractController _controller;
        public RecruimentControllerTest()
        {
            _mockRepo = new Mock<ICultureService>();
            _controller = new ContractController(_mockRepo.Object);
        }

        [TestMethod]
        public void GetContractByLogin()
        {

            User UserLogin = new User();
            UserLogin.Login = "BAONV";
            UserLogin.Password = "123";
            string result = _controller.CalculateHashCommand(UserLogin);
            Assert.IsNotNull(result);

        }
      

    }
}
