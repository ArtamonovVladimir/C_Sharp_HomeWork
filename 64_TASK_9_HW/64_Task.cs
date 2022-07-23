namespace VladimirArtamonov
{
    public static class HomeWorkTask64
    {
        //Задача 64. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
        //M = 1; N = 5. -> ""1, 2, 3, 4, 5""
        //M = 4; N = 8. -> ""4, 6, 7, 8""

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите значения M и N, натуральные числа между которыми будут напечатаны на экране.");
            Console.Write("\nВведите значения M:\t");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите значения N:\t");
            int numberN = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nНатуральные числа в промежутке от M до N:\t");
            RecursionPrintOfNaturalNumbers(numberM, numberN);
        }


        public static void RecursionPrintOfNaturalNumbers(int startNumber, int endNumber)
        {
            if (startNumber > endNumber)
            {
                return;
            }
            else
            {
                Console.Write($"{startNumber} ");
                RecursionPrintOfNaturalNumbers(startNumber + 1, endNumber);
            }
        }
    }
}


