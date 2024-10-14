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
            if (n>1 & n <= daysinm)
            {
                string g1 = g.ToString();
                string m1 = m.ToString();
                int d = n - 1;
                string n1 = d.ToString();
                string res = g1 + " " + m1+ " " + n1;
                return res;
            }
            else
            {
                if (n==1 & m > 1)
                {
                    int d;
                    switch (m-1)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            d = 31;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            d = 30;
                            break;
                        case 2:
                            d = 29;
                            break;
                        
                    }
                    string g1 = g.ToString();
                    int m1 = m - 1;
                    string m2 = m1.ToString();
                    
                    string d1 = daysinm.ToString();
                    string res = g1 + " " + m2 + " " + d1;
                    return res;
                    
                }
                else
                {
                    int d = g - 1;
                    string g1 = d.ToString();
                    string res = g1 + " "+ "12" + " "+"31";
                    return res;
                    
                }
            }
        }
    }
}
