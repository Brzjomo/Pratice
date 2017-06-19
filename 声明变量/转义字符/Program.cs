using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("我说:\"好吧，那就没办法了。\"");//用法是:反斜杠'\'加上符号

            Console.ReadKey();

            Console.WriteLine("   他身子微微一震，怒声道:\"先有老菊后有天，太阳骑士日神仙！\n吾王高贵的身体，可是尔等愚蠢的贱民可以随意触碰的？\"");//'\n'代表回车

            Console.ReadKey();

            Console.WriteLine("   二文闻声哈哈大笑，笑道最后隐隐有些哭腔，\"原来啊\b这么多年来，我们在他的眼中还只是贱民？\"\b");//'\b'表示退格，删除前一个字符，但放在末尾不起作用

            Console.ReadKey();

            Console.WriteLine("   \"别上了他的道！\"，搞事见情况不妙赶紧说道，\"难道你忘了他当初在避难所亲口对我们说的话了吗？如果你忘了就打开黑匣下的Z:\\未来科技避难所\\他.log看看清楚！\"");//要显示‘\’时，前面再加一个'\'转义

            Console.ReadKey();

            Console.WriteLine("{0} {1}","233","666666");

            Console.WriteLine("{0} {1}","1","999999999999");

            Console.WriteLine("{0}\t{1}", "233", "666666");//'\t'制表符，让字符串自动对齐

            Console.WriteLine("{0}\t{1}", "1", "999999999999");

            Console.ReadKey();

            Console.WriteLine(@"a\b\c\d\e\f\h\i\j\k");//'@'使字符取消转义，原样输出

            Console.ReadKey();

            Console.WriteLine(@"
                先有老菊后有天，
                太阳骑士日神仙。");//使字符串保留格式，原样输出

            Console.ReadKey(); 
        }
    }
}
