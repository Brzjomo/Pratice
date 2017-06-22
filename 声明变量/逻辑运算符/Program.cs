using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //逻辑与：&&
            //表达式都为真，结果才为真

            //逻辑或：||
            //表达式有一个为真，结果就为真

            //逻辑非：!
            //表达式为真，则结果为假；表达式为假，则结果为真 

            //例子：让用户输入科目一、科目二的成绩，然后判断：
            //（1）.科目一、科目二成绩都超过90分
            //（2）.科目一、科目二有一门成绩超过90分
            //结果输出为‘True’或‘False’。

            Console.WriteLine("请输入科目一的成绩：");

            int sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入科目二的成绩：");

            int sub2 = Convert.ToInt32(Console.ReadLine());

            bool result1 = sub1 > 90;

            bool result2 = sub2 > 90;

            bool compare1 = result1 && result2;

            bool compare2 = result1 || result2;

            Console.WriteLine("(1).两门成绩都超过90分：{0}",compare1);

            Console.WriteLine("(2).有一门成绩超过90分：{0}",compare2);

            Console.ReadKey();

            //各运算符的优先级：
            // ++-- > 算数运算符 > 关系运算符 > 逻辑运算符 > 赋值运算符 '=' 

            //练习：写一个程序，判断用户输入的年份是否是闰年。已知：
            //      （1）.年份能够被400整除
            //      （2）.年份能够整除4，但不能整除100
            //     满足以上两个条件之一，则该年为闰年。

            Console.WriteLine("请输入要判断是否为闰年的年份：");

            int year = Convert.ToInt32(Console.ReadLine());

            bool comp1 = year % 400 == 0;

            bool comp2 = year % 4 == 0 && year % 100 != 0;

            bool comp = comp1 || comp2;

            Console.WriteLine("是否为闰年：{0}",comp);

            Console.ReadKey(); 

        }
    }
}
