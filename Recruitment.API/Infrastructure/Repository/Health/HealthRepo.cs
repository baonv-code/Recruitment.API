using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.API.Infrastructure.Repository
{
    public class HealthRepo : IHealthRepo
    {
        class Health
        {

            public string Value1 { get; set; }
            public string Value2 { get; set; }
        }

        /// <summary>
        /// Get All Health
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetAll()
        {
            try
            {
                List<Health> healths = new List<Health>{
                   new Health{Value1="abcd",Value2="bdef"},
                   new Health{Value1="1234",Value2="5678"}
                   };

                return healths;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
