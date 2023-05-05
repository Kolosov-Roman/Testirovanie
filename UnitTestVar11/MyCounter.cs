
namespace UnitTestVar11
{
    public class MyCounter
    {
        private double result = 0.0;

        public MyCounter() { }
        public void Count(double x, double a, double b, double c)
        {
            if (x < 1 && c != 0)
            {
                result = a * x * x + (b / c);
                return;
            }
            if (x > 1.5 && c == 0)
            {
                result = (x - a) / ((x - c) * (x - c));
                return;
            }
            else
            {
                result = (x * x) / (c * c);
                return;
            }
        }

        public double GetResult()
        {
            return result;
        }
    }
}
