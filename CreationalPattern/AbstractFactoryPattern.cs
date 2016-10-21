using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern
{
    /*抽象对象模式
    1 创建产品公共接口（多个） 2 创建产品类（多个） 3 创建工厂接口 4 创建工厂类（多个）
    */
    public class AbstractFactoryPattern
    {
        /// <summary>
        /// 产品A接口
        /// </summary>
        public interface ProductA
        {

        }

        /// <summary>
        /// 产品B接口
        /// </summary>
        public interface ProductB
        {

        }

        /// <summary>
        /// 春天A产品
        /// </summary>
        public class SpringA : ProductA
        {
            //定义字段
            private string name; 

            /// <summary>
            /// 获取产品名
            /// </summary>
            /// <returns></returns>
            public string getName()
            {
                return name;
            }

            /// <summary>
            /// 设置产品名
            /// </summary>
            /// <param name="name"></param>
            public void setName(string name)
            {
                this.name = name;
                Console.WriteLine("春天A产品名：" + this.name);
            }
        }

        /// <summary>
        /// 春天B产品
        /// </summary>
        public class SpringB : ProductB
        {
            //定义字段
            private string name;

            /// <summary>
            /// 获取产品名
            /// </summary>
            /// <returns></returns>
            public string getName()
            {
                return name;
            }

            /// <summary>
            /// 设置产品名
            /// </summary>
            /// <param name="name"></param>
            public void setName(string name)
            {
                this.name = name;
                Console.WriteLine("春天B产品名：" + this.name);
            }
        }

        /// <summary>
        /// 创建工厂接口
        /// </summary>
        public interface FactoryC
        {
            ProductA createProductA();
            ProductB createProductB();
        }

        /// <summary>
        /// 春天工厂
        /// </summary>
        public  class springFactoryC : FactoryC
        {
            public  ProductA createProductA()
            {
                return new SpringA();
            }

            public  ProductB createProductB()
            {
                return new SpringB();
            }
        }



    }
}
