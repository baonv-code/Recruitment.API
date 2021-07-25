using CommandQuery;
using Recruitment.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Recruitment.API.Infrastructure.Repository
{
    public class ContractCommandHandler : ICommandHandler<Contract>
    {
        private readonly ICultureService _cultureService;

        public ContractCommandHandler(ICultureService cultureService)
        {
            _cultureService = cultureService;
        }

        public Task HandleAsync(Contract command)       {
           

            return Task.FromResult<Contract>(_cultureService.GetContract());
        }
        
    }
}
