using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryproxoie.Account
{

    [DataContract(Name = "User1", Namespace = "Ecole.Businesslayer.Etudiants")]

    public class User
    {
        
       
        [DataMember]
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }

        public string Statut { get; set; }
       
         

    }
   
}



