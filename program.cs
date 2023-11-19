using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1O1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
                
                double temp1 = 0;
                double temp2 = 0;
                double temp3 = 0;
                double nmbr1 = 0;
                double nmbr2 = 0;
                double nmbr3 = 0;
                double nmbr4 = 0;
                double nmbr5 = 0;
                double nmbr6 = 0;
                //^ variables
                Console.Write("Birinci sayıyı giriniz: ");
                temp1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz: ");
                temp2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Üçüncü sayıyı giriniz: ");
                temp3 = Convert.ToDouble(Console.ReadLine());
                //User Input                
                nmbr1 = Math.Min(temp1, temp2);
                nmbr2 = Math.Min(nmbr1, temp3);
                //^ Finds the smallest number
                nmbr3 = Math.Max(temp1, temp2);
                nmbr4 = Math.Max(nmbr3, temp3);
                //^ Finds the biggest number 
                Console.WriteLine("En Küçük Sayı: " + nmbr2);

                Console.WriteLine("En Büyük Sayı: " + nmbr4);
                //Line 41&43 = tty/Cli Output
            }

            catch(Exception e)
            {
                Console.WriteLine("ERR: " + e.Message);
                Console.WriteLine("--- PRESS ANY KEY TO EXIT ---");

            }



        }
    }
}
