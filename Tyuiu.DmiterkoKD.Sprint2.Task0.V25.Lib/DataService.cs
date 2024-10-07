using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DmiterkoKD.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x - 46 == y;
            res[1] = x != y;
            res[2] = x - 47 < y;
            res[3] = x - 47 > y;
            res[4] = x <= y;
            res[5] = x - 47 >= y;
            return res;
        }
    }
}
