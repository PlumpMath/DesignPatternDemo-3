using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern
{
    /* 单例模式
    确保一个对象只会有一个实例化的对象存在,同时在多线程中也要确保这点
    此处为懒汉模式。
    饿汉模式是，对静态变量加 static readonly 关键字赋值。这样确保不存在多线程的问题。
    优点是获取对象速度快，但是类加载速度慢些。懒汉模式跟它相反
    */
    public class SingletonPattern
    {
        /// <summary>
        /// 定义私有静态单例类变量
        /// </summary>
        private static SingletonPattern instance;

        /// <summary>
        /// 定义私有锁，确保多线程下的单例模式
        /// </summary>
        private static object _lock = new object();

        /// <summary>
        /// 私有构造方法
        /// </summary>
        private SingletonPattern() { }

        /// <summary>
        /// 获取实例对象
        /// </summary>
        /// <returns></returns>
        public static SingletonPattern GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {//实例为空时加锁
                    if (instance == null)
                    {//为实例初始化
                        instance = new SingletonPattern();
                        Console.WriteLine("执行了实例化");
                    }
                }
            }
            return instance;
        }

    }
}
