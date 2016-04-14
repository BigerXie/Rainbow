using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Core.Wcf
{
    public interface IBussinessService
    {
        ResponseMessage Process(RequestMessage request);
    }
}
