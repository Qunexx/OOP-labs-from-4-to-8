using System;
using System.Runtime.InteropServices;

namespace MyClass
{
    public abstract class ParentClass
    {
        protected static double _a = 0.0;
        protected static double _b = 0.0;
        protected static int _d = 0;
        protected static double Result;

        public double a
        {
            get { return _a; }
            set
            {
                if (value == 0)
                    throw new Exception("Нулевое значение a недопустимо!");
                else
                    _a = value;
            }
        }

        public double b
        {
            get { return _b; }
            set
            {
                if (value == 0)
                    throw new Exception("Нулевое значение b недопустимо!");
                else
                    _b = value;
            }
        }

        public int d
        {
            get { return _d; }
            set
            {
                if (value == 0)
                    throw new Exception("Нулевое значение d недопустимо!");
                else
                {
                    _d = value;
                }
            }
        }

        public static double Get_Result
        {
            get { return Result; }
        }

        public void CalcValue()
        {
            Result = Calc();

        }

        public virtual double Calc()
        {
            return 0;
        }

        public string ToString(string suffix)
        {
            return suffix + Result;
        }
    }

    public class Calc1 : ParentClass   //Первое выражение
    {
        public override  double Calc()
        {
            Result = ((_a + _b) / _a + (_a - _b) / _b);
            return Result;
        }

        public override string ToString()
        {
            return "Ответ 1 =" + Get_Result;
        }
    }

    public class Calc2 : ParentClass //Второе выражение
    {
        public override double Calc()
        {

            double step = 0;

            for (int i = 0; i < _d; i++)
            {
                step = (i + 1) / (_a + _d) / _a + i * (_a - _d) / _d;
                Result += step;

            }
            return Result;
        }
        public override String ToString()
        {
            return "Ответ 2 =" + Get_Result;
        }
        
      
    }
}






