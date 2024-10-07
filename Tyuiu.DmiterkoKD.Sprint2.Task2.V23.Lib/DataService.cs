using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DmiterkoKD.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 & x <= 5 & y >= 3 & y <= 5) | (x == 6 & y == 5) | (x >= 9 & x <= 12 & y >= 3 & y <= 4) | (x >= 7 & x <= 12 & y >= 5 & y <= 11) | (x == 13 & y >= 6 & y <= 8) | (x == 13 & y == 11) | (y == 12 & x >= 12 & x <= 13) | (y == 12 & x >= 7 & x <= 10) | (y == 11 & x >= 3 & x <= 6) | (x == 6 & y >= 9 & y <= 10))
            {
                return true;
            }
            return false;
        }
    }
}
