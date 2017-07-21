using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01 //資料夾
{
    internal class Program  //檔案  (不在同一個資料內的檔案無法互相通用
    {
        private static void Main(string[] args)
        {
            Calculator iphone = new Calculator();
            // 型態      變數     新增   物件
            Console.WriteLine(iphone.Add(2, 3));
            //也可寫成 int result = iphone.Add(2, 3);
            //        Console.WriteLine(result);
        }
    }
}