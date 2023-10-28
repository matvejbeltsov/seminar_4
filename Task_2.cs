using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using Microsoft.Win32.SafeHandles;

namespace Task_2
{
    internal class Program
    {
        static int sum_numbers(int chislo){
            int sum_numbers = 0;
            
            while(chislo != 0){
                sum_numbers += chislo % 10;
                chislo /= 10;
            }

            return sum_numbers;
        }
       
        static void Main(string[] args)
        {
            int chislo = Convert.ToInt32(Console.ReadLine());
            int result = sum_numbers(chislo);
            Console.WriteLine("Вводимое число: " + chislo + '\n' + "Сумма цифр этого числа: " + result);
        }
    }
}
