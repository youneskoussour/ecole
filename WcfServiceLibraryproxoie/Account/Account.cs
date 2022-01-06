using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Voxel.Services.Helpers.WCF;

namespace WcfServiceLibraryproxoie.Account
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Account : IAccountServices
    {
        public User EtEtudiantinfo()
        {
            throw new NotImplementedException();
        }

        public User EtEtudiantinfo(User user)
        {
            User tmpResult = new User();
            SyncProxyHelper<IAccountServices>.Use(
                EndPoint.Name.ecoleWcfLibraryproxoie_BasicHttpEndPointAccount.ToString(),
                serviceProxy =>
                {
                    tmpResult = serviceProxy.EtEtudiantinfo(user);
                }
            );
            return tmpResult;
        }

        public bool EtudiantIdAdmit(User user)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(Account user)
        {
            throw new NotImplementedException();
        }

        public bool Login(User user)
        {

            bool tmpResult = false;
            SyncProxyHelper<IAccountServices>.Use(
                EndPoint.Name.ecoleWcfLibraryproxoie_BasicHttpEndPointAccount.ToString(),
                serviceProxy =>
                {
                    tmpResult = serviceProxy.Login(user);
                }
            );
            return tmpResult;


        }


    }
}

