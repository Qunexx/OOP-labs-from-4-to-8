using System;

namespace MyClass
{
    public class MyCalc
    {
        protected static double _a = 0.0;
        protected static double _b = 0.0;
        private static int _d;
        protected static double Result = 0;
        
        public static double a
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

        public static double b
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
        public static int d
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

        public static String ToString(double number)
        {
            String str = "ответ = " + number.ToString();
            return str;
        }
        public override String ToString()
        {
            return "ответ = " + Get_Result;
        }


        //Первое выражение
        public static double calc(double _a,double _b)
        {
            Result = ((_a + _b) / _a + (_a - _b) / _b);
            return Result;
        }



        //Сумма (i+1)/(a+d)/a + i*(a-d)/d для i=0,d

        public static double calc(double _a,int _d)
        {

            double step = 0;
            
            for (int i = 0; i < _d; i++)
            {
                step = (i + 1) / (_a + _d) / _a + i * (_a - _d) / _d;
                Result += step;

            }

            return Result;
        }

      
    }
}






