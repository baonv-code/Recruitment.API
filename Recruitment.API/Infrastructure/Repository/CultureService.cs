using Recruitment.Client.Models;
using Recruitment.Contracts.Models;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Recruitment.API.Infrastructure.Repository
{
    public interface ICultureService
    {

        string  CalculateHashCommand(User user);
         Contract GetContract();


    }

    public class CultureService : ICultureService
    {
        public string CalculateHashCommand(User user)
        {
         

            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(user.Password + user.Login));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
           
        }

        public Contract GetContract()
        {
            Contract contract = new Contract();
            return contract;
        }
    }
}