using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关系运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //'>'大于，'<'小于
            //'=='等于，'!='不等于
            //'>='大于等于，'<='小于等于

            Console.WriteLine(5<10);
            //正确--True

            Console.WriteLine(5>10);
            //错误--False

            //C#中'对错'用bool类型表示，只有‘True’、‘False’两个值

            bool l1 = 5 < 10;

            bool l2 = 5 > 10;

            //关系表达式：由关系运算符连接的表达式
            //关系表达式的类型为：bool类型

            Console.WriteLine("l1={0},l2={1}",l1,l2);

            Console.ReadKey(); 
        }
    }
}
