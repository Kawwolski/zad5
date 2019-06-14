using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
   public class BankAccount
    {
        public int ind { get; internal set; }
        public double acount { get; internal set; }

        private static double offset=0.03;

        public BankAccount(double account,int id)
        {
            acount=account;
            ind=id;
        }


        internal static void Changeoffset(double newOffset)
        {
            offset = newOffset;
            
        }

        public void GetCash(double cash)
        {
            acount = acount - cash - (cash * offset);
           
        }

        public void Transfer(BankAccount account2,double cash)
        {
            acount = acount - cash - (cash * (0.5*offset));
            account2.acount = account2.acount + cash;
        }

    }
}
