using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            Console.WriteLine("请输入年龄：");

            try//'try'中的代码按顺序执行，当第一行出错后，后面的代码都不会执行，转而执行‘catch’中的代码
            {
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("你的年龄为：{0}", age);

            }
            catch//‘catch’必须写在‘try’后面，中间不能插入其他代码
            {
                Console.WriteLine("输入的值必须为数字！");
            }

            Console.ReadKey(); 
        }
    }
}
