
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using Recruitment.API;

namespace Recruitment.Test
{
  
    public  class CommandControlerTest
    {
        public class when_using_the_real_controller
        {
            [SetUp]
            public void SetUp()
            {
                var factory = new WebApplicationFactory<Startup>();
                Client = factory.CreateClient();
            }

            [Test]
            public async Task should_work()
            {
                var content = new StringContent("{ \"ContractNo\": \"123\" }", Encoding.UTF8, "application/json");
                var result = await Client.PostAsync("/api/command/Contract", content);

                result.EnsureSuccessStatusCode();
                (await result.Content.ReadAsStringAsync()).Should().BeEmpty();
            }
            [Test]
            public async Task LoginTest()
            {
                var content = new StringContent("{ \"Login\": \"123\",\"pass\": \"123\" }", Encoding.UTF8, "application/json");
                var result = await Client.PostAsync("/api/Contract/CalculateHashCommand", content);

                result.EnsureSuccessStatusCode();
                (await result.Content.ReadAsStringAsync()).Should().BeEmpty();
            }           

            HttpClient Client;
        }
    }
}
