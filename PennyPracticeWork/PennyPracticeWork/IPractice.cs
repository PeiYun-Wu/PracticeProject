using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPracticeWork
{
    interface IPractice
    {
        //方法:存款
        void PayIn(int amount);

        //方法:收款
        bool GetMoney(int amount);

        //屬性:帳戶餘額
        int Balance { get; }
    }
}
