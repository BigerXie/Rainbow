using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Core.Container
{
    /// <summary>
    /// 对象工厂
    /// </summary>
    public sealed class ObjectFactory
    {
        private IList<IObjectContainer> _Containers;

        private static readonly object _SyncRoot = new object();

        private static ObjectFactory _Instance;
        public static ObjectFactory Instance
        {
            get
            {
                //双重锁定
                if (_Instance == null)
                {
                    lock (_SyncRoot)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new ObjectFactory();
                        }
                    }
                }
                return _Instance;
            }
        }

        private ObjectFactory()
        {
            this._Containers = new List<IObjectContainer>();
            //this._Containers.Add(new MefObjectContainer());
            this._Containers.Add(new SpringObjectContainer());
        }
        internal void InitContainer()
        {
            foreach (var container in this._Containers)
            {
                container.InitContainer();
            }
        }
        public T GetObject<T>()
        {
            return (T)this.GetObject<T>(typeof(T).FullName);
        }
        public T GetObject<T>(string name)
        {
            foreach (var container in this._Containers)
            {
                var result = container.GetObject<T>();
                if (result != null)
                    return result;
            }
            throw new Exception(string.Format("未找到名称为【{0}】的对象", name));
        }
    }
}
