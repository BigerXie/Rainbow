using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Core.Container
{
    internal class MefObjectContainer : IObjectContainer
    {

        public void InitContainer()
        {
            throw new NotImplementedException();
        }

        public T GetObject<T>()
        {
            throw new NotImplementedException();
        }

        public T GetObject<T>(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetObjects<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetObjects<T>(string name)
        {
            throw new NotImplementedException();
        }
    }
}
