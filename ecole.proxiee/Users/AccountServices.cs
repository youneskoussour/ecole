using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecole.proxie.Users
{
    public class AccountServices : IAccountServices
    {
        public string Login(User user)
        {
            string tmpResult = null;
            SyncProxyHelper<AccountServices>.Use(
                EndPoints.Name.ecoleCommercialWebService_BasicHttpEndPoint.ToString(),
                serviceProxy =>
                {
                    tmpResult = serviceProxy.Login(User);
                }
            );
            return tmpResult;
        }

      
    }

    
}