using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Rainbow.Contracts
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        void Test(string request);
    }
}
