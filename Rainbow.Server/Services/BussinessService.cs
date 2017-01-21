using Rainbow.Contracts;
using Rainbow.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Server.Services
{
    public class BussinessService : IBussinessService
    {
        public ResponseMessage Process(RequestMessage request)
        {
            return new ResponseMessage() { Status = ResponseStatus.OK, Result = "Hello Client" };
        }
    }
}
