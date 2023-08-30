using System;

namespace Lab53
{
    public class Class
    {
        public static double MathF(double x)
        {
            double y = 2 * (Math.Cos(x) * Math.Cos(x) - 1);
            return y;
        }
        public static double MathF_1(double x)
        {
            
            double y = 2 * (Math.Cos(x) * Math.Cos(x) - 1);
            double s = 0;
            double pow = -1;
            int factorial = 2;
            for (int n = 1; n <= 8; n++)
            {
                s += pow * Math.Pow(2 * x, 2 * n) / factorial;
                pow *= -1;
                factorial *= (2 * n + 1) * (2 * n + 2);
            }
            return s;
        }
        //Разработайте программу отображения функций Y(x), S(x) и их разности из лабораторной работы 1.3 с помощью компонента Chart.
        //Используйте три серии данных. 
        
        
    }
}