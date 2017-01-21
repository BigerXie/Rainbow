using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.DataContract
{
    public class RequestMessage
    {
        public RequestHeader Header { get; set; }

        public RequestBody Body { get; set; }
    }
}
