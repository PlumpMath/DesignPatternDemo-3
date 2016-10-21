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
            //SimpleFactoryPattern.Sender mail = SimpleFactoryPattern.SenderFactory.ProduceMail();
            //SimpleFactoryPattern.Sender sms=SimpleFactoryPattern.SenderFactory.ProduceSMS();
            //mail.Send();
            //sms.Send();

            AbstractFactoryPattern.ProductA springA = new AbstractFactoryPattern.springFactoryC().createProductA();
            ((AbstractFactoryPattern.SpringA)springA).setName("春天1");
            ((AbstractFactoryPattern.SpringA)springA).getName();

            AbstractFactoryPattern.ProductB springB = new AbstractFactoryPattern.springFactoryC().createProductB();
            ((AbstractFactoryPattern.SpringB)springB).setName("春天2");
            ((AbstractFactoryPattern.SpringB)springB).getName();




            Console.ReadLine();

        }
    }
}
