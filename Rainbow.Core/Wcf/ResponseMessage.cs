using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Core.Wcf
{
    public class ResponseMessage
    {
        public ResponseStatus Status { get; set; }

        public string Result { get; set; }

        public string ExceptionMessage { get; set; }
    }
}
