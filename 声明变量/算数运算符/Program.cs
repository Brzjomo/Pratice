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

            //      double      int      double

            //运算符两边的数据类型必须一致，包括‘=’两边的数据类型
            //运算符两边的数据类型不一致时，必须先进行转换，然后进行计算

            //隐式类型转换：自动将低精度数据转换成高精度数据，不会丢失数据精度

            //转换要求：数据类型兼容

            Console.WriteLine("总共需要:\"{0}\"魂,打67折后需要:\"{1}\"魂。",sumSouls,disSouls);

            Console.ReadKey();

            int point = (int)235.3;

            //显式类型转换：强制转换数据类型，高精度数据转换到低精度数据，强制丢失数据精度

            Console.WriteLine(point);

            Console.ReadKey();

            //例子： int a = 10;
            //      int b = 3;
            //      double result = a / b;
            //输出的结果是多少？

            int a = 10;
            int b = 3;
            double result = a / b;

            Console.WriteLine(result);

            Console.ReadKey();

            double result1 = 10 / 3 * 1.0;
            //从左到右计算   int/int * 1   对结果没有影响

            double result2 = 1.0 * 10 / 3;
            //从左到右计算       double/int   将‘10’的数据类型从‘int’转换成了‘double’

            Console.WriteLine("{0},{1}",result1,result2);

            Console.ReadKey();

            //数据类型不兼容的情况下：

            //将字符串233转换为数字

            int test = Convert.ToInt32("233");

            Console.WriteLine(test+1);

            Console.ReadKey();

            //要求：字符串必须由数字‘0~9’组成

            //将字符串66.66转换为数字

            double test2 = Convert.ToDouble("66.66");

            Console.WriteLine(test2+1);

            Console.ReadKey();

            //例子：根据用户输入的3个分数，显示“分数：x分，x分,x分”

            Console.WriteLine("请输入科目一的分数：");

            string socore1 = Console.ReadLine();

            Console.WriteLine("请输入科目二的分数：");

            string socore2 = Console.ReadLine();

            Console.WriteLine("请输入科目三的分数：");

            string socore3 = Console.ReadLine();

            double soc1 = Convert.ToDouble(socore1);

            double soc2 = Convert.ToDouble(socore2);

            double soc3 = Convert.ToDouble(socore3);

            double sumsoc = soc1 + soc2 + soc3;

            double avgsoc = sumsoc / 3;

            Console.WriteLine("你的三门总分为：\"{0}\"，三门的平均分为：\"{1}\"",sumsoc,avgsoc);

            Console.ReadKey();

            //练习1：计算输入的天数为几周零几天

            Console.WriteLine("请输入要计算的天数：");

            string dayinput = Console.ReadLine();

            int days = Convert.ToInt32(dayinput);

            int weeks = days / 7;

            int leftdays = days % 7;

            Console.WriteLine("换算结果为：\"{0}周，零{1}天\"",weeks,leftdays);

            Console.ReadKey();

            //简化代码：

            Console.WriteLine("请输入要计算的天数：");

            int days2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("换算结果为：\"{0}周，零{1}天\"",days2/7,days2%7);

            Console.ReadKey();

            //练习2：107653秒是几年几月几日几小时几分钟几秒

            Console.WriteLine("请输入要换算的秒数：");

            int seconds = Convert.ToInt32(Console.ReadLine());

            int year = seconds / ( 60 * 60 * 24 * 30 * 12);//输出年

            int year2 = seconds % (60 * 60 * 24 * 30 * 12);

            int month = year2 / ( 60 * 60 * 24 * 30);//输出月

            int month2 = year2 % (60 * 60 * 24 * 30);

            int day = month2 / ( 60 * 60 * 24 );//输出日

            int day2 = month2 % (60 * 60 * 24);

            int hour = day2 / ( 60 * 60 );//输出小时

            int hour2 = day2 % (60 * 60);

            int minute = hour2 / 60;//输出分钟

            int second = hour2 % 60;//输出秒 

            Console.WriteLine("换算结果为：\"{0}年{1}月{2}日{3}时{4}分{5}秒\"",year,month,day,hour,minute,second);

            Console.ReadKey();

            //++--

            int p1 = 10;

            int p2 = ++p1 + 4;//11+4

            p1 = 10;

            int p3 = p1++ + 4;//10+4

            //'++'在前，先自加一再运算
            //‘++’在后，先运算再自加一

            //'--'也是一样

            Console.WriteLine("{0},{1}",p2,p3);

            Console.ReadKey();

            //复合运算符：+=，-=，*=，/=，%=

            int n1 = 3;

            n1 += 5;//结果为8，等价于'n1=n1+5'

            Console.WriteLine(n1);

            n1 -= 6;//结果为2，等价于'n1=n1-6'

            Console.WriteLine(n1);

            n1 *= 4;//结果为8，等价于'n1=n1*4'

            Console.WriteLine(n1);

            n1 /= 2;//结果为4，等价于'n1=n1/2'

            Console.WriteLine(n1);

            n1 %= 3;//结果为1，等价于'n1=n1%3'

            Console.WriteLine(n1);

            Console.ReadKey(); 

            //由一种运算符构成的运算符，比如‘++’，叫作一元运算符
            //由两种运算符构成的运算符，比如‘+=’，叫作二元运算符 

            //一元运算符的优先级高于二元运算符 

        }
    }
}
