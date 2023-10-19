//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//пример:
//6 -> да
//7 -> да
//1 -> нет

 Console.Write("Введите номер дня недели (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            if (dayNumber == 6 || dayNumber == 7)
            {
                Console.WriteLine("Да, это выходной день.");
            }
            else
            {
                Console.WriteLine("Нет, это не выходной день.");
            }
        }
        else
        {
            Console.WriteLine("Введите номер дня недели от 1 до 7.");
        }
    