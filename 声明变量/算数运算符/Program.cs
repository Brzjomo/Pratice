using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算数运算符
{
    class Program
    {
        static void Main(string[] args)
        {

            // + - * / % (%为取余)

            int num1 = 3;

            int num2 = 28;

            Console.WriteLine(num2%num1);//num2对num1取余，就是num2除以num1后得的余数

            Console.ReadKey();

            //老菊平A银骑士，第一下打出155的伤害，第二下打出178，第三下出了暴击451。求老菊3下伤害的总和，以及平均伤害。

            double damge1 = 155;
            double damge2 = 178;
            double damge3 = 451;//使用double，是因为如果除不尽可以显示小数，而int整数则会自动取整，按需求使用

            double sumDamge = damge1 + damge2 + damge3;

            double avrDamge = sumDamge / 3;//如果加减乘除放一个表达式里，可以使用小括号

            Console.WriteLine("老菊的伤害总和为：\"{0}\",平均伤害为:\"{1}\"",sumDamge,avrDamge);

            Console.ReadKey();

            //练习1：计算半径为6CM的圆的周长和面积？（π取3.14，周长公式：C=2πr，面积公式：S=πr²）

            double π = 3.14;

            int r = 6;

            double c = 2 * π * r;

            double s = π * r * r;

            Console.WriteLine("圆的周长为:\"{0}厘米\",面积为:\"{1}平方厘米\"。",c,s);

            Console.ReadKey();

            //练习2：假设老妪那里余烬2500魂一个，雷壶1000魂一个。那么买3个余烬和5个雷壶要用多少魂？如果打67折又要多少呢？

            int item1 = 2500;
            int item2 = 1000;

            int sumSouls = item1 * 3 + item2 * 5;

            double disSouls = sumSouls * 0.67;

            Console.WriteLine("总共需要:\"{0}\"魂,打67折后需要:\"{1}\"魂。",sumSouls,disSouls);

            Console.ReadKey(); 

        }
    }
}
