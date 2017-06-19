using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量
{
    class 声明变量
    {
        static void Main(string[] args)
        {
            int age;//整数 变量名‘age’

            age = 21;//初始化变量（赋值，又称赋值表达式）

            Console.WriteLine(age);//输出变量‘age’的值

            Console.ReadKey();//等待输入

            age = age + 1;//表达式：由运算符连接的式子

            Console.WriteLine(age);//输出变量‘age’新值

            Console.ReadKey();

            int year = 2017;//定义变量并初始化

            Console.WriteLine(year);

            Console.ReadKey();

            double pai = 3.1415927;//定义并初始化小数变量‘pai’

            Console.WriteLine(pai);

            Console.ReadKey();

            string name = "小乔";//定义字符串，字符串要用‘双引号’引用，引号内内容可为空，可为单个字母或汉子

            Console.WriteLine("你好,"+name+"!");

            Console.ReadKey();

            char gender = '女';//定义字符（单个字母或汉子），必须用单引号，引号内不能为空

            Console.WriteLine(gender);

            Console.ReadKey();

            //string等函数，首字母小写为C#中定义的，大写的‘String’为中间语言（MSIL）定义的，两者都可用，推荐用C#语言的定义

            decimal money = 213.5m;//定义金钱小数类型，金钱小数类型对比double类型，数值范围更大、精度更高

            Console.WriteLine(money);

            Console.ReadKey();

        }
    }
}
