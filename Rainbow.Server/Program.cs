using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Rainbow.Core.RainbowContext.InitCore();
            Console.WriteLine("Server is running...");
            Console.ReadKey();
        }
    }
}
