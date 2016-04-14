using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.UnitTest.Service
{
    public class HelloService : IHelloService
    {

        public string SayHi()
        {
            return "Hello Rainbow!";
        }
    }
}
