using System;

namespace mini_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Закрыть");
            Console.WriteLine("Выберите: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Угадай число");
                    int x = new Random().Next(1, 101);
                    int y = 0;
                    bool z = false;

                    Console.WriteLine("Угадай число от 1 до 100:");

                    while (!z)
                    {
                        int c = int.Parse(Console.ReadLine());
                        y++;

                        if (c < x)
                        {
                            Console.WriteLine("Число больше. Давай ещё");
                        }
                        else if (c > x)
                        {
                            Console.WriteLine("Число меньше. Давай ещё");
                        }
                        else
                        {
                            Console.WriteLine("Угадал! Попыток:" + y );
                            z = true;
                        }
                    }

                    Console.WriteLine("Нажми любую клавишу для выхода");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Таблица умножения");
                    int stroka = 10;
                    int stolbik = 10;

                    int[,] tablica = new int[stroka, stolbik];

                    for (int a = 0; a < stroka; a++)
                    {
                        for (int b = 0; b < stolbik; b++)
                        {
                            tablica[a, b] = (a + 1) * (b + 1);
                        }
                    }

                    Console.WriteLine("Таблица умножения:\n");

                    for (int i = 0; i < stroka; i++)
                    {
                        for (int j = 0; j < stolbik; j++)
                        {
                            Console.Write(tablica[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Закрытие программы");
                    break;
                default:
                    Console.WriteLine("Ошибка! Такого выбора нет");
                    break;
            }
        }
    }
}

