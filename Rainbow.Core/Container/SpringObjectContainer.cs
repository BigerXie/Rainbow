using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Core.Container
{
    internal class SpringObjectContainer : IObjectContainer
    {
        private readonly string _ConfigPath = @"Config\SpringConfig.xml";

        private bool _IsInit = false;

        private Spring.Context.IApplicationContext _SpringContext;

        public void InitContainer()
        {
            try
            {
                if (!_IsInit)
                {
                    _SpringContext = new Spring.Context.Support.XmlApplicationContext(_ConfigPath);
                    _IsInit = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetObject<T>()
        {
            return (T)this.GetObject<T>(typeof(T).FullName);
        }

        public T GetObject<T>(string name)
        {
            if (!_IsInit || this._SpringContext == null)
            {
                this.InitContainer();
            }
            if (this._SpringContext.ContainsObject(name))
            {
                return (T)this._SpringContext.GetObject(name);
            }
            return default(T);
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
