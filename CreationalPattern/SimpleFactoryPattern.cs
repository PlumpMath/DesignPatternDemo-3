using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern
{
    /*
    简单工厂模式
    1 创建公共接口 2 初始化产品类基础接口 3 创建工厂类，实现创建产品功能
    */

    public class SimpleFactoryPattern
    {
        /// <summary>
        /// 发送接口
        /// </summary>
        public interface Sender
        {
            /// <summary>
            /// 发送方法
            /// </summary>
            void Send();
        }

        /// <summary>
        /// 邮件类
        /// </summary>
        public class MailSender : Sender
        {
            public void Send()
            {
                Console.WriteLine("邮件发送。。。");
            }
        }

        /// <summary>
        /// 短信类
        /// </summary>
        public class SMSSender : Sender
        {
            public void Send()
            {
                Console.WriteLine("短信发送。。。");
            }
        }

        /// <summary>
        /// 工厂类
        /// </summary>
        public class SenderFactory
        {
            /// <summary>
            /// 创建邮件类
            /// </summary>
            /// <returns></returns>
            public static Sender ProduceMail()
            {
                return new MailSender();
            }

            /// <summary>
            /// 创建短信类
            /// </summary>
            /// <returns></returns>
            public static Sender ProduceSMS()
            {
                return new SMSSender();
            }
        }

    }
}
