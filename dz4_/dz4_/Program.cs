using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz4_
{
    internal class Program
    {
        static void ChangesValue(int firstnum, int secondnum, int[] random)
        {
            int firstIndex = Array.IndexOf(random, firstnum);
            int secondIndex = Array.IndexOf(random, secondnum);

            random[firstIndex] = secondnum;
            random[secondIndex] = firstnum;
        }
        static int Calculationsnums(ref int product, out double averageval, params int[] randomvals)
        {
            int summ = 0;

            foreach (int number in randomvals)
            {
                summ += number;
                product *= number;
            }

            averageval = (double)summ / randomvals.Length;

            return summ;
        }
        static void Draw(string[] Numpikctu)
        {
            try
            {
                string srtinge;
                int num;
                bool result;

                do
                {
                    Console.Write("Введите целое число от 0 до 9: ");
                    srtinge = Console.ReadLine();
                    result = int.TryParse(srtinge, out num);

                    if (result)
                    {
                        if (num >= 0 && num <= 9)
                        {
                            Console.WriteLine(Numpikctu[num]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели число меньше 0 или больше 9");
                            Thread.Sleep(3000);
                            Console.ResetColor();
                        }
                    }
                    else if (srtinge.ToLower() == "exit" || srtinge.ToLower() == "закрыть")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        throw new Exception("Вы ввели не число или оно является дробным");
                    }
                } while (!(srtinge.ToLower() == "exit" || srtinge.ToLower() == "закрыть"));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.Write("Чтобы закончить выполнение упражнения, нажмите на любую кнопку ");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1");
            int[] random = new int[20];
            int firstnum, secondnum;
            bool firstres, secondres;
            Random random1 = new Random();
            Console.WriteLine();
            for (int i = 0; i < random.Length; i++)
            {
                int number = random1.Next(50);
                Console.Write(number + " ");
                random[i] = number;
            }
            Console.WriteLine("Два числа из массива меняются местами");

            do
            {
                Console.Write("Введите первое число из массива: ");
                firstres = int.TryParse(Console.ReadLine(), out firstnum);
                Console.Write("Введите второе число из массива: ");
                secondres = int.TryParse(Console.ReadLine(), out secondnum);

                if (firstres && secondres && (Array.IndexOf(random, firstnum) != -1) && (Array.IndexOf(random, secondnum) != -1))
                {
                    ChangesValue(firstnum, secondnum, random);

                    Console.Write("Массив изменился: ");

                    foreach (int number in random)
                    {
                        Console.Write(number + " ");
                    }

                }
                else
                {
                    Console.WriteLine("Вы ввели неверные данные");
                }
            } while (!(firstres && secondres && (Array.IndexOf(random, firstnum) != -1) && (Array.IndexOf(random, secondnum) != -1)));

            Console.WriteLine("Упражнение 2");

            Random randomval = new Random();
            int[] randomvals = new int[randomval.Next(1, 15)];
            int summ;
            double averageval;
            int product = 1;

            Console.Write("Получился массив: ");

            for (int i = 0; i < randomvals.Length; i++)
            {
                int number = randomval.Next(20);
                Console.Write(number + " ");
                randomvals[i] = number;
            }

            summ = Calculationsnums(ref product, out averageval, randomvals);

            Console.WriteLine($"Сумма чисел равна {summ}, произведение - {product}, среднее арифметическое - {averageval:F}");

            Console.WriteLine();

            string[] Numpikctu = { "\t#####\n\t#   #\n\t#   #\n\t#   #\n\t#   #\n\t#   #\n\t#####\n",
                                                     "\t    #\n\t  # #\n\t #  #\n\t    #\n\t    #\n\t    #\n\t    #\n",
                                                     "\t#####\n\t    #\n\t    #\n\t#####\n\t#    \n\t#    \n\t#####\n",
                                                     "\t#####\n\t    #\n\t    #\n\t#####\n\t    #\n\t    #\n\t#####\n",
                                                     "\t#   #\n\t#   #\n\t#   #\n\t#####\n\t    #\n\t    #\n\t    #\n",
                                                     "\t#####\n\t#    \n\t#    \n\t#####\n\t    #\n\t    #\n\t#####\n",
                                                     "\t#####\n\t#    \n\t#    \n\t#####\n\t#   #\n\t#   #\n\t#####\n",
                                                     "\t######\n\t#    #\n\t    #\n\t  #####\n\t    #\n\t    #\n\t    #\n",
                                                     "\t#####\n\t#   #\n\t#   #\n\t#####\n\t#   #\n\t#   #\n\t#####\n",
                                                     "\t#####\n\t#   #\n\t#   #\n\t#####\n\t    #\n\t    #\n\t#####\n" };
            Draw(Numpikctu);


        }
    }
}
