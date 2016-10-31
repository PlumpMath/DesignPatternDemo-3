using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern
{
    /* 原型模式
    使用原型实例指定待创建对象的类型，并且通过复制这个原型来创建新的对象
    拷贝有深拷贝和浅拷贝之分。
    */
    public class PrototypePattern
    {
        /// <summary>
        /// 抽象原型类
        /// </summary>
        public abstract class PrototypeCls
        {
            public abstract PrototypeCls Clone();  //克隆方法
        }

        /// <summary>
        /// 具体类
        /// </summary>
        public class ConcretePrototypeCls : PrototypeCls
        {
            /// <summary>
            /// 定义特性
            /// </summary>
            private string attr;
            public string Attr { get { return attr; } set { attr = value; } }

            /// <summary>
            /// 克隆方法实现
            /// </summary>
            /// <returns></returns>
            public override PrototypeCls Clone()
            {
                ConcretePrototypeCls cls = new ConcretePrototypeCls();
                cls.Attr = attr;
                Console.WriteLine("执行克隆方法");
                return cls;
            }

        }

    }
}
