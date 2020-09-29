using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readline1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            int price, qty;
            Console.WriteLine();
            Console.WriteLine("   LKK_SHOP");
            Console.WriteLine("  ======================");
            Console.Write("   1. BOOK NAME：");
            str1 = Console.ReadLine();        // 輸入書名並指定給str1變數
            Console.Write("   2. Price ：");
            // 輸入售價並使用int.Parse()方法將輸入的資料轉成整數，再指定給qty
            price = int.Parse(Console.ReadLine());
            Console.Write("   3. quantity：");
            // 輸入數量並使用Convert.ToInt32()方法將輸入的資料轉成整數，再指定給qty
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ======================");
            Console.WriteLine($"   4. Amount：{price * qty}");
            Console.Read();
        }
    }
}
