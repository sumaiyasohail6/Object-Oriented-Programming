using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_TASKS
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            float length;
            float area;
            string str;
            Console.WriteLine("Enter Length: ");
            str = Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.WriteLine($"The area is: {area}");
        }


    }
}
