using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PozhdinAA.Sprint2.Task3.V25.Lib;

namespace Tyuiu.PozhdinAA.Sprint2.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Пождин А. А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Вложенные операторы if - else                                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных оператор if - else, где пользователь вводит  *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}