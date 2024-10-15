using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DmiterkoKD.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int day;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    day = 29;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }

            if (n > 1 & n <= day)
            {
                n = n - 1;
                string g1 = g.ToString();


                string n1 = n.ToString();
                string m1 = m.ToString();
                string n2;
                if (n1.Length == 1)
                {
                    n2 = "0" + n1;

                }
                else
                {
                    n2 = n1;

                }
                string m2;
                if (m1.Length == 1)
                {
                    m2 = "0" + m1;

                }
                else
                {
                    m2 = m1;

                }
                string a = n2 + "." + m2 + "." + g1;
                return a;

            }
            else if (n ==1 & m !=1)
            {
                string day2;
                switch (m-1)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        day2 = "31";
                        break;
                    case 2:
                        day2 = "29";
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day2 = "30";
                        break;
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
                string g1 = g.ToString();
                int m2 = m - 1;
                string m3 = m2.ToString();
                string m4;
                if (m3.Length == 1)
                {
                    m4 = "0" + m3;

                }
                else
                {
                    m4 = m3;

                }
                string a = day2 + "." + m4 + "." + g1;
                return a;
            }
            else 
            {
                int g1 = g - 1;
                string g2 = g1.ToString();
                string a = "31.12" +"." + g2;
                return a;
            }
        }
    }
}
