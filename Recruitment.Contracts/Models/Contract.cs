using CommandQuery;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Contracts.Models
{


    //public class ContractQuery : ICommand
    //{
    //    public string reuslt { get; set; }
       
    //}

    public class Contract: ICommand
    {
        public Guid ContractId { get; set; }
        public string ContractNo { get; set; }
        public DateTime ContractDate { get; set; }
        public string Expire { get; set; }
        public DateTime ExpireDate { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }

      
    }
}
