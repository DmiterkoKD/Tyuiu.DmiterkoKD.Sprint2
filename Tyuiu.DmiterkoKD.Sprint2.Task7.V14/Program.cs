using Tyuiu.DmiterkoKD.Sprint2.Task7.V14.Lib;
namespace Tyuiu.DmiterkoKD.Sprint2.Task7.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программy, которая запрашивает исходные данные и вычисляет,    *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области");
            }
        }
    }
}
