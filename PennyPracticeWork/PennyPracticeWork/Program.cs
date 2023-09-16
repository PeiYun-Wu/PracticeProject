using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPracticeWork
{
    //在介面中，我們要去定義與規範類別成員
    //介面中不會去寫任何得邏輯
    //而且介面的成員永遠都是公用的，所以不需要也不能加上public
    //如果需要簽合約的類別就必須繼承介面

    class Program   
    {
        //包含繼承的宣告方式
        public static IPractice chickenAtm = new Practice();

        static void Main(string[] args)
        {
            //先讓客人選擇功能
            Console.WriteLine();
            Console.WriteLine("請選擇需要模式");
            Console.WriteLine("存款請按1，領款請按2");
            string goFuncton = Console.ReadLine();


            //判斷要使用哪個方法
            if (goFuncton == "1")//領錢
            {
                Console.WriteLine("請輸入要存入的金額!");
                int amount = Convert.ToInt32(Console.ReadLine());
                //付款方法
                chickenAtm.PayIn(amount);
            }
            else if (goFuncton == "2")
            {
                Console.WriteLine("請輸入要領取的金額!");
                int amount = Convert.ToInt32(Console.ReadLine());
                //付款方法
                chickenAtm.GetMoney(amount);
            }

            Console.WriteLine("目前餘額 : " + chickenAtm.Balance);

            //這邊用遞迴來讓方法可以持續輪迴
            string[] array = new string[0];
            Main(array);
        }
    }
    public class Practice : IPractice //繼承介面,需實作所有介面
    {
        private int blance;
        public bool GetMoney(int amount)
        {
            if (blance >= amount)
            {
                blance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("餘額不足，取款失敗!");
                return false;
            }
        }

        public void PayIn(int amount)
        {
            blance += amount;
        }
        public int Balance
        {
            get
            {
                return blance;
            }
        }
    }
}
