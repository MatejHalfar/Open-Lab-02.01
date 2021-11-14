using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] pole = { 1.2, 2.3, 3.4, 4.5, 5.6 };
            return pole;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}