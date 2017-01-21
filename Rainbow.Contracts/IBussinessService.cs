using Rainbow.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Rainbow.Contracts
{
    [ServiceContract]
    public interface IBussinessService
    {
        [OperationContract]
        ResponseMessage Process(RequestMessage request);
    }
}
