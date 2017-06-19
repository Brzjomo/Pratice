using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 交换变量的值
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25;

            int num2 = 9;

            int num3 = 0;

            num3 = num1;

            num1 = num2;

            num2 = num3;

            Console.WriteLine("Num1={0},Num2={1}",num1,num2);

            Console.ReadKey();

            //通过数学运算交换变量的值

            num1 = num1 + num2;

            num2 = num1 - num2;

            num1 = num1 - num2;

            Console.WriteLine("Num1={0},Num2={1}",num1,num2);

            Console.ReadKey(); 

        }
    }
}
