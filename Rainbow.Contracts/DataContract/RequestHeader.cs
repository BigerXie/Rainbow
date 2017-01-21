using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.DataContract
{
    public class RequestHeader
    {
        public string ClientIPAddress { get; set; }

        public string User { get; set; }

        public string Token { get; set; }
    }
}
