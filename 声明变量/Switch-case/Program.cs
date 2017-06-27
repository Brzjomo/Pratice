using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //老王工资5000，公司规定按年终评定调动工资，规则如下：
            //评级‘A’则涨500，评级‘B’则涨200，评级‘C’则不变，评级‘D’则降200，评级‘E’则降500
            //用户输入评级，然后显示来年工资

            int salary = 0;

            string rank = "--";

            bool judge1 = false;

            bool judge2 = false;

            try
            {

                Console.WriteLine("请输入目前工资：");

                salary = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("输入内容必须为数字！");

                judge1 = true;

            }

            if (judge1 == false)
            {

                try
                {

                    Console.WriteLine("请输入年终评级：");

                    rank = Console.ReadLine();

                }
                catch
                {
                    Console.WriteLine("输入内容必须为‘A’、‘B’、‘C’、‘D’、‘E’！");

                    judge2 = true;

                }

                if (judge2 == false)
                {

                    if (rank == "A")
                    {
                        salary = salary + 500;

                        Console.WriteLine("来年工资为：{0}", salary);
                    }
                    else if (rank == "B")
                    {
                        salary = salary + 200;

                        Console.WriteLine("来年工资为：{0}", salary);
                    }
                    else if (rank == "C")
                    {
                        Console.WriteLine("来年工资为：{0}", salary);
                    }
                    else if (rank == "D")
                    {
                        salary = salary - 200;

                        Console.WriteLine("来年工资为：{0}", salary);
                    }
                    else if (rank == "E")
                    {
                        salary = salary - 500;

                        Console.WriteLine("来年工资为：{0}", salary);
                    }
                    else
                    {
                        Console.WriteLine("输入内容必须为'A'、'B'、'C'、'D'、'E'！");
                    }

                }

            }

            Console.ReadKey();

            //switch -case 用于多条件、定值判断

            try
            {
                bool judge3 = false;

                Console.WriteLine("请输入工资：");

                salary = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("请输入年终评级：");

                rank = Console.ReadLine();

                switch (rank)
                {
                    case "A":
                        salary += 500;
                        break;

                    case "B":
                        salary += 200;
                        break;

                    case "C":
                        break;

                    case "D":
                        salary -= 200;
                        break;

                    case "E":
                        salary -= 500;
                        break;

                    default:
                        Console.WriteLine("输入内容必须为‘A’、‘B’、‘C’、‘D’、‘E’！");
                        judge3 = true;
                        break;
                }

                if (judge3 == false)
                {

                    Console.WriteLine("来年工资为：{0}", salary);

                }
            }
            catch
            {
                Console.WriteLine("输入内容必须为数字！");
            }

            Console.ReadKey(); 
        }
    }
}
