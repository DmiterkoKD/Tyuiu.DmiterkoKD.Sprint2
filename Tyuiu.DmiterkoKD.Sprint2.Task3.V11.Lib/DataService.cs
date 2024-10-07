using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DmiterkoKD.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                double y = x + Math.Pow(((x - 15) / (x - 19)), x);
                return Math.Round(y, 3);
            }
            else
            {
                if (x == 0)
                {
                    double y = (x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12);
                    return Math.Round(y, 3);
                }
                else
                {
                    if (x > -15 & x < 0)
                    {
                        double y = Math.Pow((1 + (1 / (x * x))), x);
                        return Math.Round(y, 3);
                    }
                    else
                    {
                        double y = x + 10 * x - (1 / x);
                        return Math.Round(y, 3);
                    }
                }
            }
        }
    }
}
