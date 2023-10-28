using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Task_1
{
    internal class Program
    {
        
        static int power(int powerBase, int exponent){
            int power = 1;
            for (int i = 0; i < exponent; i++){
                power *= powerBase;
            }
            return power;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основание степени: ");
            int powerBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень, в которую хотите возвести число");
            int exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число возведенное в введенную степень: " + power(powerBase, exponent));
        }
    }
}