using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加号应用实例
{
    class 个人介绍
    {
        static void Main(string[] args)
        {

            //我叫王老菊，今年26岁，性别女，别人都叫我猛男，但我只是一朵阳台上可爱的小红FA。我经营着一家跨银河系公司，叫王老菊未来科技有限公司。生意从中世纪的赵日天到火星殖民都有涉猎。但我最喜欢的生意还是给古龙修脚，给哥哥们倒茶。
            //在未来科技各位员工的努力工作下，我们公司去年年销售额突破了9800亿老菊币。顺带一提，老菊币是我司研制，银河系第一人民银行发行的一种六维货币。老菊币的单币价值可以在旧地球买入一整个非洲，可以说是非常的牛爆。
            //我今年订婚了，另一半叫免免。能遇见他是我这辈子最大的幸福。好了，不多说了。二文刚刚通知我，葛温老头来了，说是古神有重现宇宙的迹象。这可是个关乎银河系的大新闻，必须要慎重处之。

            string name = "王老菊";

            int age = 26;

            char gender = '女';

            string nickname = "猛男";

            string selfnickname = "可爱的小红FA";

            string company = "王老菊未来科技有限公司";

            decimal sale = 9800;

            string hisname = "免免";

            Console.WriteLine("    我叫"+name+"，今年"+age+"岁，性别"+gender+"，别人都叫我"+nickname+ "，但我只是一朵阳台上" +selfnickname+ "。我经营着一家跨银河系公司，叫" +company+ "。生意从中世纪的赵日天到火星殖民都有涉猎。但我最喜欢的生意还是给古龙修脚，给哥哥们倒茶。");

            Console.ReadKey();

            Console.WriteLine("   在未来科技各位员工的努力工作下，我们公司去年年销售额突破了"+sale+ "亿老菊币。顺带一提，老菊币是我司研制，银河系第一人民银行发行的一种六维货币。老菊币的单币价值可以在旧地球买入一整个非洲，可以说是非常的牛爆。" );

            Console.ReadKey();

            Console.WriteLine("   我今年订婚了，另一半叫"+hisname+ "。能遇见他是我这辈子最大的幸福。好了，不多说了。二文刚刚通知我，葛温老头来了，说是古神有重现宇宙的迹象。这可是个关乎银河系的大新闻，必须要慎重处之。");

            Console.ReadKey();

            //占位符

            Console.WriteLine("   我叫{0}，今年{1}岁，性别{2}，别人都叫我{3}，但我只是一朵阳台上{4}。我经营着一家跨银河系公司，叫{5}。",name,age,gender,nickname,selfnickname,company);

            Console.ReadKey(); 

        }
    }
}
