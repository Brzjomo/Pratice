using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If语句练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：提示用户输入密码，如果输入‘amazing123’提示密码正确，否则提示密码错误，提示重新输入

            Console.WriteLine("请输入密码：");

            string pass1 = Console.ReadLine();

            if (pass1 == "amazing123")
            {
                Console.WriteLine("密码正确");
            }
            else
            {
                Console.WriteLine("密码错误！请重新输入密码！");
            }

            Console.ReadKey();

            //练习2：提示用户输入用户名和密码，如果输入的是‘南方’，密码‘noodass123’提示登陆成功；如果输入用户名不是‘南方’则提示用户不存在；如果用户名正确而密码不正确则提示密码错误

            Console.WriteLine("请输入用户名：");

            string userName1 = Console.ReadLine();

            if (userName1 == "南方")
            {
                Console.WriteLine("请输入密码：");

                string pass2 = Console.ReadLine();

                if (pass2 == "noodass123")
                {
                    Console.WriteLine("登陆成功");
                }
                else
                {
                    Console.WriteLine("密码错误！");
                }
            }
            else
            {
                Console.WriteLine("用户名不存在！"); 
            }

            Console.ReadKey();

            //练习3：提示用户输入年龄，如果用户年满18则可以查看，小于10岁则不可查看，介于10到18岁则提示是否继续，如果输入‘是’则查看，否则不查看

            Console.WriteLine("请输入你的年龄：");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("符合要求，可以查看");
            }
            else if (age >= 10)//‘else if’按照顺序判断条件，满足一个条件后不再检查是否满足后面的条件；如果是‘if’，程序会挨个检查所有条件，所有满足的条件都会输出一个结果
            {
                Console.WriteLine("你未满18岁，是否继续查看？   ---是/否");

                string juge = Console.ReadLine();

                if (juge == "是")
                {
                    Console.WriteLine("你已同意，继续浏览");
                }
                else
                {
                    Console.WriteLine("你已拒绝，停止浏览");
                }
            }
            else
            {
                Console.WriteLine("你的年龄不符要求，已终止浏览");
            }

            Console.ReadKey(); 
        }
    }
}
