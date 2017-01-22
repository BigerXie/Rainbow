using Rainbow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Server.Services
{
    public class MessageService : IMessageService
    {
        public void Test(string request)
        {
            Console.WriteLine("MessageService Receive...");
        }
    }
}
