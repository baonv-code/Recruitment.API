using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.API.Infrastructure.Repository
{
    public interface IHealthRepo
    {
        /// <summary>
        /// Get All Health
        /// </summary>
        /// <returns>List Health</returns>
        public IEnumerable<object> GetAll();



    }
}
