using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace adminservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<string> LoginUserDetails(UserDetails userInfo);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "adminservice.ContractType".

        [DataContract]
        public class UserDetails
        {
            string email = string.Empty;
            string password = string.Empty;
            //string empid;

            [DataMember]
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            [DataMember]
            public string Password
            {
                get { return password; }
                set { password = value; }
            }
            
        }
    
}
