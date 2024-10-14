using Tyuiu.DmiterkoKD.Sprint2.Task6.V12.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год: "); 
            int  g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите порядковый номер месяца: "); 
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число: "); 
            int n = Convert.ToInt32(Console.ReadLine());

            string res;
            if (((m < 1) || (m > 12)) & (n<1 || n>31))
            {
                res = "Введеное значение неверно!";
            }
            else
            {
                res = "Предыфдущие число: " + ds.FindDateOfPreviousDay(g, m, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
        }
    }
}
