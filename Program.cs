using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_3.Else_İf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 5600;

            Console.WriteLine("ATM xos gelmisiniz");
            Console.WriteLine("Emeliyyat novunu secin");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Show the balance on the screen " + balance);
                Console.ReadLine();
            }


            else if (choice == "2")
            {
                Console.WriteLine("Cixarilacag meblegi secin");
                int cixarilacag_mebleg = Convert.ToInt32(Console.ReadLine());
                if (cixarilacag_mebleg <= balans)
                {
                    Console.WriteLine("Qalan pulunuz: " + (balance - cixarilacag_mebleg));
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Secdiyiniz mebleg hesabinizda movcud deyil");
                    Console.ReadLine();
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Yatirilacag meblegi secin");
                int yatirilacag_mebleg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hal hazirki pulunuz: " + (balance + yatirilacag_mebleg));
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                Console.WriteLine("ATM den cixis edilir");
                Console.WriteLine("Cixis edildi tesekkurler... ");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Duzgun emeliyyat novunu secin");
                Console.ReadLine();
            }
        }
    }
}
