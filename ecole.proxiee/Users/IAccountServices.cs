﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ecole.proxie.Users
{
    [ServiceContract]   
   public class IAccountServices
    {
       
        
            [OperationContract]
            bool EtudiantIdAdmit(User user);
            [OperationContract]
            bool Login(User user);
            [OperationContract]
            User EtEtudiantinfo(User email);
        }
    }

