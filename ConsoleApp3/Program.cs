using System;

namespace ConsoleApp3
{
    public class Programm
    {
        public static double Min(double x,double a,double b,double c)
        {
            double y;
            if (x < 0.6 && b + c != 0) //29
            {
                y = a*Math.Pow(x,3)+Math.Pow(b,2)+c;
                return y;
            }
            else if (x > 0.6 && b + c == 0)//1,75
            {
                y = (x - a) / (x - c);
                return y;
            }
            else
            {
                y = (x / c) + (x / a);
                return y;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
