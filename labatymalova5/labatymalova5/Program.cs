using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labatymalova5
{
    class Program
    {
        static int Maxnum(int firstnum, int secondnum)
        {
            if (firstnum > secondnum)
            {
                return firstnum;
            }
            else
            {
                return secondnum;
            }
        }
        static void Changevalue(ref string firstvalue, ref string secondvalue)
        {
            string thirdvalue = firstvalue;
            firstvalue = secondvalue;
            secondvalue = thirdvalue;
        }
        static bool Factorial(out int factorial, int num)
        {
            try
            {
                factorial = 1;

                for (int i = 1; i <= num; i++)
                {
                    checked
                    {
                        factorial *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                factorial = -1;
                return false;
            }
        }
        static int Factorialrecursion(int num1)
        {
            if (num1 == 1)
            {
                return 1;
            }
            return num1 * Factorialrecursion(num1 - 1);
        }
        static int NOD(int firstnum2, int secondnum2)
        {
            int ost, result;
            do
            {
                ost = firstnum2 % secondnum2;
                firstnum2 = secondnum2;
                result = secondnum2;
                secondnum2 = ost;
            } while (ost != 0);

            return result;
        }
        static int NOD(int firstnum3, int secondnum3, int thirdnum3)
        {
            int del = NOD(firstnum3, secondnum3);
            int result = NOD(del, thirdnum3);

            return result;
        }
        static int Fibonnum(int numberval)
        {
            if (numberval == 1 || numberval == 2)
            {
                return 1;
            }

            return Fibonnum(numberval - 1) + Fibonnum(numberval - 2);
        }
        static void Main(string[] args)
        {
            bool taskend = false;
            string tasknum;
            do
            {
                Console.WriteLine("Лаба Тумакова 5 - меню заданий");
                Console.WriteLine("Подсказка:\n" +
                                  "Упражнение 5.1. Программа возвращает максимальное из двух введенных целых чисел   -   цифра 1\n" +
                                  "Упражнение 5.2. Программа меняет местами два передаваемых значения                -   цифра 2\n" +
                                  "Упражнение 5.3. Программа вычисляет факториал числа с помощью цикла               -   цифра 3\n" +
                                  "Упражнение 5.4. Программа вычисляет факториал числа с помощью рекурсии            -   цифра 4\n" +
                                  "Домашнее задание 5.1. Программа вычисляет НОД двух и трех чисел                   -   цифра 5\n" +
                                  "Домашнее задание 5.2. Программа вычисляет значение n-го числа ряда Фибоначчи      -   цифра 6\n" +
                                  "Выйти из программы                                                                -   цифра 0\n");

                Console.Write("Введите номер задания: ");
                tasknum = Console.ReadLine();
                

                switch (tasknum)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Упражнение 5.1");

                            int firstnum, secondnum, Maxnum1;
                            bool firstres, secondres;

                            do
                            {
                                Console.Write("Введите первое целое число: ");
                                firstres = int.TryParse(Console.ReadLine(), out firstnum);
                                Console.Write("Введите второе целое число: ");
                                secondres = int.TryParse(Console.ReadLine(), out secondnum);

                                if (firstres && secondres)
                                {
                                    Maxnum1 = Maxnum(firstnum, secondnum);

                                    Console.WriteLine($"max({firstnum}, {secondnum}) = {Maxnum1}");
                                    Console.Write("Чтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели неверные данные, повторите попытку");
                                }
                            } while (!(firstres && secondres));
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Упражнение 5.2");
                            string firstvalue, secondvalue;

                            Console.Write("Введите первое значение: ");
                            firstvalue = Console.ReadLine();
                            Console.Write("Введите второе значение: ");
                            secondvalue = Console.ReadLine();

                            Changevalue(ref firstvalue, ref secondvalue);

                            Console.WriteLine($"Значения поменялись местами \n Первое значение - {firstvalue}, второе значение - {secondvalue}");
                            Console.Write("Нажмите на любую кнопку ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Упражнение 5.3");
                            int factorial, num;
                            bool factorialres = true;
                            bool parseres;

                            do
                            {
                                Console.Write("Введите натуральное число, большее нуля: ");
                                parseres = int.TryParse(Console.ReadLine(), out num);

                                if (parseres && num > 0)
                                {
                                    factorialres = Factorial(out factorial, num);

                                    if (factorialres)
                                    {
                                        Console.WriteLine($"{num}! = {factorial}");
                                        Console.Write("Чтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"При вычислении {num} получилось слишком большое число");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели число или оно не натуральное");
                                }
                            } while (!(parseres && num > 0 && factorialres));
                            break;
                        }
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Упражнение 5.4");
                        int factorial1, num1;
                        bool parseres1;

                        do
                        {
                            Console.Write("Введите натуральное число, большее нуля: ");
                            parseres1 = int.TryParse(Console.ReadLine(), out num1);

                            if (parseres1 && num1 > 0)
                            {
                                factorial1 = Factorialrecursion(num1);

                                if (factorial1 == 0)
                                {
                                    Console.WriteLine($"При вычислении {num1} получилось слишком большое число");
                                    Console.Write("Чтобы выйти нажмите на любую кнопку");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine($"{num1}! = {factorial1}");
                                    Console.Write("Чтобы выйти нажмите на любую кнопку");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы Ввели неверные данные ");
                            }
                        } while (!(parseres1 && num1 > 0));
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Домашнее упражнение 5.1");

                        int firstnum2, secondnum2, thirdnum2, nod;
                        bool firstres2, secondres2, thirdres2;

                        do
                        {
                            Console.Write("Введите первое натуральное число: ");
                            firstres2 = int.TryParse(Console.ReadLine(), out firstnum2);
                            Console.Write("Введите второе натуральное число: ");
                            secondres2 = int.TryParse(Console.ReadLine(), out secondnum2);

                            if ((firstres2 && secondres2) && (firstnum2 > 0 && secondnum2 > 0))
                            {
                                nod = NOD(firstnum2, secondnum2);

                                Console.WriteLine($"НОД({firstnum2}, {secondnum2}) = {nod}");
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели не число или оно не натуральное");
                            }
                        } while (!((firstres2 && secondres2) && (firstnum2 > 0 && secondnum2 > 0)));

                        do
                        {
                            Console.Write("Введите первое натуральное число: ");
                            firstres2 = int.TryParse(Console.ReadLine(), out firstnum2);
                            Console.Write("Введите второе натуральное число: ");
                            secondres2 = int.TryParse(Console.ReadLine(), out secondnum2);
                            Console.Write("Введите третье натуральное число: ");
                            thirdres2 = int.TryParse(Console.ReadLine(), out thirdnum2);

                            if ((firstres2 && secondres2 && thirdres2) && (firstnum2 > 0 && secondnum2 > 0 && thirdnum2 > 0))
                            {
                                nod = NOD(firstnum2, secondnum2, thirdnum2);

                                Console.WriteLine($"НОД({firstnum2}, {secondnum2}, {thirdnum2}) = {nod}");
                                Console.Write("Чтобы завершить что-нибудь тыкните");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Число является не числом или оно не натуральное");
                            }
                        } while (!((firstres2 && secondres2 && thirdres2) && (firstnum2 > 0 && secondnum2 > 0 && thirdnum2 > 0)));
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("ДЗ упражнение 5.2");
                        int numberval, fibonnum;
                        bool parseres3;
                        do
                        {
                            Console.Write("Введите номер числа из ряда Фибоначчи: ");
                            parseres3 = int.TryParse(Console.ReadLine(), out numberval);

                            if (parseres3 && numberval > 0)
                            {
                                fibonnum = Fibonnum(numberval);

                                Console.WriteLine($"{numberval} число из ряда Фибоначчи равно {fibonnum}");
                                Console.Write("Чтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели неверные данные");
                            }
                        } while (!(parseres3 && numberval > 0));
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Завершение работы");
                        taskend = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Нет такого задания");
                        break;
                }
            } while (!taskend);
        }
    }
}
