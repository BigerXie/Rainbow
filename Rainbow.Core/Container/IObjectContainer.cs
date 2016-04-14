using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Core.Container
{
    /// <summary>
    /// 容器接口
    /// </summary>
    internal interface IObjectContainer
    {
        void InitContainer();

        T GetObject<T>();

        T GetObject<T>(string name);

        IEnumerable<T> GetObjects<T>();

        IEnumerable<T> GetObjects<T>(string name);
    }
}
