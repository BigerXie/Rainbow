using Rainbow.Core.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainbow.Core
{
    /// <summary>
    /// 初始化Rainbow
    /// </summary>
    public class RainbowContext
    {
        public static void InitCore()
        {
            //初始化Spring容器及Orm
            ObjectFactory.Instance.InitContainer();
            
        }
    }
}
