using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern
{
    /*建造者模式
    创建产品类，创建建造者类，创建导演类
    导演类调用建造者，建造者建造产品，产品展现。
    */
    public class BuilderPattern
    {
        /// <summary>
        /// 产品类
        /// </summary>
        public class Product
        {
            Queue queue = new Queue();

            /// <summary>
            /// 添加到队列
            /// </summary>
            /// <param name="str"></param>
            public void Add(string queue)
            {
                this.queue.Enqueue(queue);
            }

            /// <summary>
            /// 展示
            /// </summary>
            public void Show()
            {
                foreach (var item in this.queue)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            
        }

        /// <summary>
        /// 建造者父类
        /// </summary>
        public class Builder
        {
            /// <summary>
            /// 创建头
            /// </summary>
            public virtual void BuildHead() { }
            /// <summary>
            /// 创建身体
            /// </summary>
            public virtual void BuildBody() { }

            /// <summary>
            /// 创建手
            /// </summary>
            public virtual void BuildHands() { }

            /// <summary>
            /// 创建脚
            /// </summary>
            public virtual void BuildFeet() { }

            /// <summary>
            /// 获取产品
            /// </summary>
            /// <returns></returns>
            public virtual Product GetResult() { return null; }
        }


        /// <summary>
        /// 胖子建造者
        /// </summary>
        public class FatPersonBuilder : Builder
        {
            private Product product;
            public FatPersonBuilder()
            {
                product = new Product();
            }
            public override void BuildHead()
            {
                product.Add("胖子增加头部\r\n");
            }

            public override void BuildBody()
            {
                product.Add("胖子增加身体\r\n");
            }

            public override void BuildHands()
            {
                product.Add("胖子增加手\r\n");
            }

            public override void BuildFeet()
            {
                product.Add("胖子增加脚\r\n");
            }

            public override Product GetResult()
            {
                return product;
            }
        }


        /// <summary>
        /// 瘦子建造者
        /// </summary>
        public class ThinPersonBuilder : Builder
        {
            private Product product=new Product();
            public override void BuildHead()
            {
                product.Add("瘦子增加头部\r\n");
            }

            public override void BuildBody()
            {
                product.Add("瘦子增加身体\r\n");
            }

            public override void BuildHands()
            {
                product.Add("瘦子增加手\r\n");
            }

            public override void BuildFeet()
            {
                product.Add("瘦子增加脚\r\n");
            }

            public override Product GetResult()
            {
                return product;
            }
        }

        /// <summary>
        /// 导演类1
        /// </summary>
        public class Director1
        {
            public Director1(Builder builder)
            {
                builder.BuildHead();
                builder.BuildBody();
                builder.BuildHands();
                builder.BuildFeet();
            }
        }

        /// <summary>
        /// 导演类2
        /// </summary>
        public class Director2
        {
            public Director2(Builder builder)
            {
                builder.BuildHead();
                builder.BuildBody();
            }
        }




    }
}
