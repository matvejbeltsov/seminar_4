using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using Microsoft.Win32.SafeHandles;

namespace Task_3
{
    internal class Program
    {
        static void random_array(int Length_array, int first_number, int second_number){
            int[] array = new int[Length_array];
            Random rand = new Random();

            for(int i = 0; i < Length_array; i++){
                array[i] = rand.Next(first_number, second_number);
            }

            for (int i = 0; i < Length_array; i++){
                Console.Write(array[i] + " ");
            }
        }
        
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int Length_array = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите границы рандомных чисел: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            int second_number = Convert.ToInt32(Console.ReadLine());
            
            random_array(Length_array, first_number, second_number);
        }
    }
}