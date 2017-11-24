using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceUsuario.Models;

namespace WcfServiceUsuario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceUsuario
    {

        [OperationContract]
        bool AddUser(string nombre, string email, string password);
        // TODO: Add your service operations here
        [OperationContract]
        bool LoginUser(string email, string password);
    }


    
}
