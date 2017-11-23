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
        string AddUser(Usuario usuario);
        // TODO: Add your service operations here
    }


    
}
