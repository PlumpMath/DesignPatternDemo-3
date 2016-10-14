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
            SimpleFactoryPattern.Sender mail = SimpleFactoryPattern.SenderFactory.ProduceMail();

            SimpleFactoryPattern.Sender sms=SimpleFactoryPattern.SenderFactory.ProduceSMS();

            mail.Send();
            sms.Send();

            Console.ReadLine();

        }
    }
}
