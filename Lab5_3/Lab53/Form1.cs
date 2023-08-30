using System;
using System.Windows.Forms;

namespace Lab53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayFunctions();
        }

        public static double MathF(double x)
        {
            double y = 2 * (Math.Cos(x) * Math.Cos(x) - 1);
            return y;
        }

        public static double MathF_1(double x)
        {
            double y= 2 * (Math.Cos(x) * Math.Cos(x) - 1);
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

        private void DisplayFunctions()
        {
            double minX = 0;
            double maxX = 1;
            double step = 0.1;

            for (double x = minX; x <= maxX; x += step)
            {
                double y = MathF(x);
                double s = MathF_1(x);
                double diff = y - s;

                chart1.Series["Y(x)"].Points.AddXY(x, y);
                chart1.Series["S(x)"].Points.AddXY(x, s);
                chart1.Series["Difference"].Points.AddXY(x, diff);
            }
        }
        
    }
}
