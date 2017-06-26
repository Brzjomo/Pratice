using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：当输入年龄大于22时，输出可以结婚

            Console.WriteLine("请输入你的年龄：");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 22)
            {
                Console.WriteLine("你已达到适婚年龄");
            }

            else
            {
                Console.WriteLine("你尚未达到适婚年龄");
            }

            Console.ReadKey();

            //练习2：满足以下条件之一，奖励一枚绿花戒指：
            //(1).敏捷大于30，力量大于30
            //(2).敏捷大于45，力量大于15

            Console.WriteLine("请输入你的敏捷值：");

            int agile = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入你的力量值：");

            int strength = Convert.ToInt32(Console.ReadLine());

            if (agile > 30 && strength > 30 || agile > 45 && strength > 15)
            {
                Console.WriteLine("这枚绿化戒你拿着吧，希望对你有用。");
            }

            else
            {
                Console.WriteLine("不，你的力量太弱小了~");
            }

            Console.ReadKey();

            //练习3：用户输入用户名“Admin”和密码“asdj1234”后提示登陆成功

            Console.WriteLine("请输入用户名：");

            string username = Console.ReadLine();

            Console.WriteLine("请输入密码：");

            string password = Console.ReadLine();

            if (username == "Admin" && password == "asdj1234")//‘=’是赋值运算符，‘==’才是等于的意思
            {
                Console.WriteLine("登陆成功！");
            }

            else
            {
                Console.WriteLine("登陆失败！");
            }

            Console.ReadKey(); 
        }
    }
}
