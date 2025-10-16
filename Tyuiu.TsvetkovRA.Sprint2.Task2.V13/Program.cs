using Tyuiu.TsvetkovRA.Sprint2.Task2.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите значение Х");
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил : Цветков Роман Андреевич | ИИПб-25-1                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и*");
        Console.WriteLine("*вычисляет находится ли точка с координатами X,Y в заштрихованной области *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("Введите значение Х");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Y");
        int y = Convert.ToInt32(Console.ReadLine());
        
        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в затемненной области");
        }
        else
        { 
            Console.WriteLine("Точка не находиться в затемненной области");
        }

        Console.ReadKey();
    }
}