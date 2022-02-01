using System;

namespace AHBC_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the length of the room in feet");
            int length = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("enter the width of the room in feet");
            int width = Convert.ToInt32(Console.ReadLine());

            int parCalc = 2*length + 2*width;

            int areaCalc = length * width;

            Console.WriteLine("Parameter of the room = " + parCalc);
            Console.WriteLine("Area of the room = " + areaCalc);

            Console.ReadLine(); 


        }
    }
}
