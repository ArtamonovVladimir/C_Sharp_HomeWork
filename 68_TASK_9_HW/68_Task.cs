namespace VladimirArtamonov
{
    public static class HomeWorkTask68
    {
        //Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        //m = 2, n = 3 -> A(m,n) = 29

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите значения M и N для вычисления функции Аккермана с помощью рекурсии.");
            Console.Write("\nВведите значения M:\t");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите значения N:\t");
            int numberN = Convert.ToInt32(Console.ReadLine());
            if (numberM >= 4 && numberN > 0 || numberN > 10)
            {
                Console.Write("\nЗначения для расчета приведут к переполнению, значение слишком большое!!!");
            }
            else
            {
                Console.Write($"\nИтог функции Аккермана m = {numberM}, n = {numberN} равен:\t");
                Console.Write(AkkermanFunction(numberM, numberN));
            }
        }


        public static int AkkermanFunction(int m, int n, int result = 0)
        {
            // Console.WriteLine($"n = {n}");
            if (m == 0)
            {
                // Console.Write($"{m},{n} -> ");
                return result = n + 1;
            }
            else if (m > 0 && n == 0)
            {
                // Console.Write($"{m},{n} -> ");
                return result = AkkermanFunction(m: m - 1, n: 1);
            }
            else if (m > 0 && n > 0)
            {
                // Console.Write($"{m},{n} -> ");
                return result = AkkermanFunction(m: m - 1, n: AkkermanFunction(m, n - 1));
            }
            else
            {
                // Console.Write($"{m},{n} -> ");
                return result = n + 1;
            }
        }
    }
}