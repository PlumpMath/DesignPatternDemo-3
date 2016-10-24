using CreationalPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ///简单工厂模式
            //SimpleFactoryPattern.Sender mail = SimpleFactoryPattern.SenderFactory.ProduceMail();
            //SimpleFactoryPattern.Sender sms=SimpleFactoryPattern.SenderFactory.ProduceSMS();
            //mail.Send();
            //sms.Send();

            ///抽象工厂模式
            //AbstractFactoryPattern.ProductA springA = new AbstractFactoryPattern.springFactoryC().createProductA();
            //((AbstractFactoryPattern.SpringA)springA).setName("春天1");
            //((AbstractFactoryPattern.SpringA)springA).getName();
            //AbstractFactoryPattern.ProductB springB = new AbstractFactoryPattern.springFactoryC().createProductB();
            //((AbstractFactoryPattern.SpringB)springB).setName("春天2");
            //((AbstractFactoryPattern.SpringB)springB).getName();

            ///建造者模式
            /// 创建建造者类
            BuilderPattern.Builder b1 = new BuilderPattern.FatPersonBuilder();
            BuilderPattern.Builder b2 = new BuilderPattern.ThinPersonBuilder();
            ///指定建造方式
            BuilderPattern.Director1 director = new BuilderPattern.Director1(b1);

            BuilderPattern.Director2 director2 = new BuilderPattern.Director2(b2);

            ///通过建造者获取产品
            BuilderPattern.Product fat= b1.GetResult();
            ///产品展示
            fat.Show();

            ///通过建造者获取产品
            BuilderPattern.Product thin = b2.GetResult();
            //产品展示
            thin.Show();

            Console.ReadLine();

        }
    }
}
