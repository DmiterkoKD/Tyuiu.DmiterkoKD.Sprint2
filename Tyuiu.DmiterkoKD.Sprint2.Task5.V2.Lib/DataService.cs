using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DmiterkoKD.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            
            string res;
            switch (value)
            {
                case 1:
                    res = "Зима";
                    break;
                case 2:
                    res = "Зима";
                    break;
                case 3:
                    res = "Весна";
                    break;
                case 4:
                    res = "Весна";
                    break;
                case 5:
                    res = "Весна";
                    break;
                case 6:
                    res = "Лето";
                    break;
                case 7:
                    res = "Лето";
                    break;
                case 8:
                    res = "Лето";
                    break;
                case 9:
                    res = "Осень";
                    break;
                case 10:
                    res = "Осень";
                    break;
                case 11:
                    res = "Осень";
                    break;
                case 12:
                    res = "Зима";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");
            }
            return res;
        }
    }
}
