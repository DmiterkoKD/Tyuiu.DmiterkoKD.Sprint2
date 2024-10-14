using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DmiterkoKD.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int daysinm;
            switch (m)
            {
                case 1: 
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysinm = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysinm = 30;
                    break;
                case 2:
                    daysinm = 29;
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
            if (n>1)
            {
                return g, m, daysinm - 1;
            }
            else
            {
                if (m>1)
                {
                    return (g, m - 1, daysinm);
                }
                else
                {
                    return (g - 1, 12, 31);
                }
            }
        }
    }
}
