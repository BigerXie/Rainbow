using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Core.Wcf
{
    public class RequestBody
    {
        public string TypeFullName { get; set; }
        public string MethodName { get; set; }
        public IList<Object> ParaValue { get; set; }
    }
}
