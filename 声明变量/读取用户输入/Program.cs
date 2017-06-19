using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 读取用户输入
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("你好，初次见面。我是小小冰，能告诉我你叫什么名字吗？");

            string name = Console.ReadLine();

            Console.WriteLine("{0},是吗？真是个不错的名字啊~",name);

            Console.WriteLine("话说，你今年多大啦？搞不好你得叫我声姐姐呢~ 嘻嘻。");

            string age = Console.ReadLine();

            Console.WriteLine("哈哈，我比你大一岁哦~ 毕竟你才{0}岁啊~",age);

            Console.WriteLine("叫声姐姐来听听，嘻嘻~");

            Console.WriteLine("你猜猜我现在在哪？给你几个选择好了~");

            Console.WriteLine("A.中国");

            Console.WriteLine("B.美国");

            Console.WriteLine("C.日本");

            Console.WriteLine("D.月球");

            string choice = Console.ReadLine();//并不会实现单选并单独显示

            Console.WriteLine("哼！肯定是瞎猜的吧~");

            Console.WriteLine("{0}先森，你今年已经{1}了。我问你啊，你偶尔会迷茫，不知道自己何去何从吗？",name,age);

            Console.ReadKey();

            Console.WriteLine("......");

            Console.ReadKey(); 

        }
    }
}
