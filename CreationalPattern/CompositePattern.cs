using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern
{
    /*组合设计模式，应用场景是：处理简单对象和复合对象时（如操作系统中的文件夹和文件的关系）
     * 虽然简单和复合对象在功能上存在差别，但是客户希望一视同仁的处理简单对象和复合对象，这个时候就使用组合设计模式
     * 组合设计模式的关键部分是简单和复合对象使用相同的接口。
     * 下面的例子使用的基本图形和复杂图形
     * 组合设计模式由三个部分组成：抽象构件、树叶构件、树枝构件
     * 组合设计分为 透明组合和安全组合，区别是是否将树枝构件的特有方法抽象
     */
    public class CompositePattern
    {
        /// <summary>
        /// 图形抽象类
        /// </summary>
        public abstract class Graphics
        {
            /// <summary>
            /// 图形名称
            /// </summary>
            public string Name { get; set; } 

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="name"></param>
            public Graphics(string name)
            {
                Name = name;
            }

            /// <summary>
            /// 画图方法
            /// </summary>
            public abstract void Draw();

            /// <summary>
            /// 新增方法
            /// </summary>
            /// <param name="g"></param>
            public abstract void Add(Graphics g);

            /// <summary>
            /// 删除方法
            /// </summary>
            /// <param name="g"></param>
            public abstract void Remove(Graphics g);

        }


        /// <summary>
        /// 线段类
        /// </summary>
        public class Line : Graphics
        {
            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="name"></param>
            public Line(string name):base(name)
            {

            }

            /// <summary>
            /// 重写画图方法
            /// </summary>
            public override void Draw()
            {
                Console.WriteLine("画：" + this.Name);
            }

            /// <summary>
            /// 重写新增方法
            /// </summary>
            /// <param name="g"></param>
            public override void Add(Graphics g)
            {
                throw new Exception("不能向简单图形Line添加其他图形");
            }

            /// <summary>
            /// 重写移除方法
            /// </summary>
            /// <param name="g"></param>
            public override void Remove(Graphics g)
            {
                throw new Exception("不能向简单图形Line移除其他图形");
            }
        }


        /// <summary>
        /// 圆类
        /// </summary>
        public class Circle : Graphics
        {
            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="name"></param>
            public Circle(string name) : base(name)
            {

            }

            /// <summary>
            /// 重写画图方法
            /// </summary>
            public override void Draw()
            {
                Console.WriteLine("画：" + this.Name);
            }

            /// <summary>
            /// 重写新增方法
            /// </summary>
            /// <param name="g"></param>
            public override void Add(Graphics g)
            {
                throw new Exception("不能向简单图形Circle添加其他图形");
            }

            /// <summary>
            /// 重写移除方法
            /// </summary>
            /// <param name="g"></param>
            public override void Remove(Graphics g)
            {
                throw new Exception("不能向简单图形Circle移除其他图形");
            }
        }

        /// <summary>
        /// 复杂图形类
        /// </summary>
        public class ComplexGraphics : Graphics
        {
            private List<Graphics> complexGrahicsList = new List<Graphics>();

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="name"></param>
            public ComplexGraphics(string name) : base(name)
            {

            }

            /// <summary>
            /// 重写画图方法
            /// </summary>
            public override void Draw()
            {
                foreach (var item in complexGrahicsList)
                {
                    item.Draw();
                }
               
            }

            /// <summary>
            /// 重写新增方法
            /// </summary>
            /// <param name="g"></param>
            public override void Add(Graphics g)
            {
                complexGrahicsList.Add(g);
            }

            /// <summary>
            /// 重写移除方法
            /// </summary>
            /// <param name="g"></param>
            public override void Remove(Graphics g)
            {
                complexGrahicsList.Remove(g);
            }
        }

    }
}
