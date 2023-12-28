using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{ 
    public class Program
    {
        public static double findDistanceBetweenPoints(double x1, double y1, double x2, double y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        static void Main(string[] args)
        {
            Console.WriteLine(findDistanceBetweenPoints(0, 0, 0, 1)); // 1
            //dont compile!!
        }
    }
}
