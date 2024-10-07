using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DmiterkoKD.Sprint2.Task4.V8.Lib
{
    public class DataService : ISprint2Task4V8
    {
        public double Calculate(double x, double y)
        {
            double z = x * 2 > y + 15 ? Math.Pow((5 + ((Math.Sqrt(y + 5)) / Math.Pow(x, 3))), x) : (2 * x * x + 2 * x - (4 + 6 / (y * y)));
            return Math.Round(z, 3);
        }
    }
}
