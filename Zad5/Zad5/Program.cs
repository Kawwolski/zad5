using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<BankAccount> list = new List<BankAccount>();

            list.Add(new BankAccount(100.00, 1));
            list.Add(new BankAccount(150.00, 2));
            list.Add(new BankAccount(200.00, 3));

            string str;
                
                do {
                Console.WriteLine("1.Stan konta");
                Console.WriteLine("2.Wypłata pieniedzy z bankomatu");
                Console.WriteLine("3.Przelew");
                Console.WriteLine("4.Wyjscie");
                str = Console.ReadLine();
                switch (str)
                {
                    case "1":

                        Console.WriteLine("Podaj Identyfikator konta");
                        int id = int.Parse(Console.ReadLine());

                        foreach (var s in list.Where(x => x.ind == id))
                        {
                            Console.WriteLine("Identyfikator konta: " + id + ".Stan konta: " + s.acount.ToString());

                        }

                        continue;
                    case "2":

                        Console.WriteLine("Podaj Identyfikator konta");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj kwote ktora chcesz wybrac");
                        double cash = double.Parse(Console.ReadLine());

                        foreach (var s in list.Where(x => x.ind == id))
                        {
                            s.GetCash(cash);
                        }

                        continue;

                    case "3":

                        Console.WriteLine("Podaj Identyfikator swojego konta");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj kwote ktora chcesz przelac");
                        cash = double.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj Identyfikator drugiego konta");
                        int fid = int.Parse(Console.ReadLine());

                        foreach (var s in list.Where(x => x.ind == id))
                        {
                           BankAccount first = s;
                            foreach (var t in list.Where(x => x.ind == fid))
                            {
                               BankAccount second = t;
                                first.Transfer(second, cash);
                            }
                            
                        }

                        continue;
                }
        } while (str != "Wyjscie");

            Console.ReadKey();
        }
    }
}


