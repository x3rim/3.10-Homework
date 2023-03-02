using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10_Homework_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            Задание 4.Наименьший элемент в последовательности
            //Что нужно сделать
            //Найдите наименьший элемент в последовательности, которую вводит пользователь.Детальный алгоритм программы:

            //            Пользователь вводит длину последовательности. 
            //Затем пользователь последовательно вводит целые числа(как положительные, так и отрицательные). Числа разделяются клавишей Enter.
            //Каждое введённое число сравнивается со значением переменной, отвечающей за минимальный элемент. Если введённое число оказывается
            //меньше, то нужно обновить значение переменной.

            //Рекомендация
            //Чтобы правильно организовать поиск наименьшего числа, на этапе инициализации переменной, отвечающей за минимальный элемент
            //в качестве начального значения минимального числа, выберите int.MaxValue.Тогда любое из чисел, которые будет вводить пользователь,
            //окажется меньше, чем это значение.

            //Что оценивается
            //Программа выводит на экран наименьшее число из последовательности пользователя.


            Console.WriteLine("Программа для определения номера, минимального элемента.\n");
            int size = 0, i = 0, number = 0, min, max, numberMin = 0;
            string str;
            bool ok = false;
            min = int.MaxValue;
            max = int.MinValue;

            while (!ok)
            {

                Console.Write("Введите количество элементов последовательности: ");
                str = Console.ReadLine();
                if (int.TryParse(str, out size) && (size > 0)) ok = true;
                else Console.WriteLine("Ошибка! Введите число элементов ");
            }
            for (i = 1; i <= size; i++)
            {
                ok = false;

                while (!ok)
                {
                    Console.WriteLine("Введите элемент {0} ", i);
                    str = Console.ReadLine();
                    if (int.TryParse(str, out number)) ok = true;
                    else Console.WriteLine("Ошибка ввода!Введите целое число!");
                    if (min > number) { min = number; numberMin = i; }
                    if (max < number) max = number;
                }

            }
            if (min == max) Console.WriteLine("Последовательность состоит из одного элемента или нескольких равных элементов. Нельзя вывести номер минимального элемента!");
            else
            {
                Console.WriteLine("Номер минимального элемента последовательности = {0}", numberMin);
            }
            Console.WriteLine("Для выхода нажмите Enter...");
            Console.ReadLine();

        }
    }
}
