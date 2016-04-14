using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainbow.Core.Container;
using Rainbow.Core;
using Rainbow.UnitTest.Service;

namespace Rainbow.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RainbowContext.InitCore();
            var helloService= ObjectFactory.Instance.GetObject<HelloService>();
            var result = helloService.SayHi();
        }
    }
}
