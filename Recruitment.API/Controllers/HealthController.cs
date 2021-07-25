using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recruitment.API.Infrastructure.Repository;
namespace Recruitment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : Controller
    {
        private IHealthRepo _repo;
        public HealthController(IHealthRepo Repo)
        {
            _repo = Repo;
        }

        #region Event
        /// <summary>
        /// Get using httpGet
        /// </summary>
        /// <returns>List Health</returns>
        [HttpGet("")]
        public IEnumerable<object> GetAllUsingGet()
        {
            return _repo.GetAll();
        }
        /// <summary>
        /// Get using httpHead
        /// </summary>
        /// <returns>List Health</returns>
        [HttpHead("")]
        public IEnumerable<object> GetAllUsingHead()
        {
            return _repo.GetAll();
        }
        #endregion

    }
}
