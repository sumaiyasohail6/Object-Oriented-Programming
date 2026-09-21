using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_TASKS
{
    internal class Task9
    {
        static double CalculateMoney(int age, double washingPrice, int toyPrice)
        {
            double savedMoney = 0;
            int toyCount = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 1)
                { 
                    toyCount++;
                }
                else
                {
                    
                    savedMoney = savedMoney + (birthday / 2) * 10;

                    
                    savedMoney = savedMoney - 1;
                }
            }

           
            savedMoney = savedMoney + toyCount * toyPrice;

            return savedMoney;
        }

        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double washingPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double savedMoney = CalculateMoney(age, washingPrice, toyPrice);

            if (savedMoney >= washingPrice)
            {
                double remaining = savedMoney - washingPrice;

                Console.WriteLine("Yes! " + remaining.ToString("0.00"));
            }
            else
            {
                double needed = washingPrice - savedMoney;

                Console.WriteLine("No! " + needed.ToString("0.00"));
            }

        }
    }
}
