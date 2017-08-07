using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainbow.Core.Container;
using Rainbow.Core;
using Rainbow.UnitTest.Service;

namespace Rainbow.UnitTest.Container
{
    [TestClass]
    public class ObjectFactoryUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            RainbowContext.InitCore();
            var helloService= ObjectFactory.Instance.GetObject<IHelloService>();
            var result = helloService.SayHi();
        }
    }
}
