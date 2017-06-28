using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //让控制台重复输出“Hello World”10便

            int count = 0;

            while (count < 10)
            {
                count += 1;

                Console.WriteLine("Hello World - "+count);

            }

            Console.ReadKey();

            //while循环，先判断再执行，可能一次都不执行

            //练习1：依次输入成绩，得出班级平均成绩

            bool judge1 = true;

            double socore = 0;

            int mateNum = 0;

            double sum = 0;

            string judge2 = "n";

            bool judge3 = false;

            try
            {

                while (judge1 == true)
                {

                    if (judge3 == false)
                    {

                        Console.WriteLine("请输入学生成绩：");

                        socore = Convert.ToInt32(Console.ReadLine());

                        mateNum++;

                        sum += socore;

                        socore = 0;

                    }

                    Console.WriteLine("是否继续输入其他学生成绩？ -- y/n");

                    judge2 = Console.ReadLine();

                    if (judge2 == "y")
                    {
                        judge1 = true;
                        judge3 = false;
                    }
                    else if (judge2 == "n")
                    {
                        judge1 = false;
                        judge3 = false;
                    }
                    else
                    {
                        Console.WriteLine("您的输入有误！");
                        judge3 = true;
                    }
                }

                if (judge3 == false)
                {

                    double average = sum / mateNum;

                    Console.WriteLine("共有学生：{0}人，平均成绩为：{1}分", mateNum, average);

                }

            }
            catch
            {
                Console.WriteLine("您的输入有误！");
            }

            Console.ReadKey();

            //do-while循环
            //先运行一遍再判断条件

            int time = 0;

            do
            {
                Console.WriteLine("Hi~");
                time++;
            } while (time < 3);

            Console.ReadKey(); 

        }
    }
}
