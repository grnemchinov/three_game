while (true)
{
    Console.WriteLine(@"Выбери действие которое хочешь выполнить:
    1.Игра угадай число
    2.Таблица умножения
    3.Вывод делителя числа
    4.Выйти из программы");
    string a = Console.ReadLine();
    if (a == "1")
    {
        Console.WriteLine("Отгадай число");
        Random rand = new Random();
        int b = rand.Next(1, 100);
        string chislo;
        Console.Write("Ваш вариант: ");
        while (true)
        {
            chislo = Console.ReadLine();

            if (int.Parse(chislo) < b)
            {
                Console.WriteLine("Задуманное число больше");
            }
            else if (int.Parse(chislo) > b)
            {
                Console.WriteLine("Задуманное число меньше");
            }
            else if (int.Parse(chislo) == b)
            {
                Console.WriteLine("Вы угадали");
                break;
            }

        }
    };
    if (a == "2")
    {
        Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
        Console.Write("--------------------------------------------------------------------------");
        Console.WriteLine();
        for (int i = 1; i < 10; i++)
        {
            Console.Write(i + "   |  ");
            for (int j = 1; j < 10; j++)
            {
                Console.Write("\t" + i * j);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    };
    if (a == "3") { };
    if (a == "4")
    {
        Environment.Exit(0);
    };
}