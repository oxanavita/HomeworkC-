// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int thirdDigit = FindThirdDigit(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine($"Третья цифра слева: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры слева нет.");
        }

    static int FindThirdDigit(int number)
    {
        number = Math.Abs(number); // Игнорируем знак числа

        while (number >= 1000)
        {
            number /= 10;
        }

        if (number < 100)
        {
            return -1; // Третьей цифры нет
        }

        return number % 10;
    }