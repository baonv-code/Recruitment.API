using Microsoft.AspNetCore.Mvc;
using Recruitment.API.Infrastructure.Repository;
using Recruitment.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : Controller
    {
        private readonly ICultureService _cultureService;

        public ContractController(ICultureService cultureService)
        {
            _cultureService = cultureService;
        }
        [HttpPost("CalculateHashCommand")]
        public string CalculateHashCommand(User user)
        {
            return _cultureService.CalculateHashCommand(user);
        }
       
    }
}
