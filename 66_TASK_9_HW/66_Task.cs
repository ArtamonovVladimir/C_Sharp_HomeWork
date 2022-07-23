namespace VladimirArtamonov
{
    public static class HomeWorkTask66
    {
        //Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        //M = 1; N = 15 -> 120
        //M = 4; N = 8. -> 30

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите значения M и N, между которыми (включая их) будет найдена и напечатана на экране сумма всех натуральных чисел.");
            Console.Write("\nВведите значения M:\t");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите значения N:\t");
            int numberN = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nСумма натуральных чисел в промежутке от {numberM} до {numberN} равно:\t");
            Console.Write(RecursionSumCulculationOfNaturalNumbers(numberM, numberN));
        }


        public static int RecursionSumCulculationOfNaturalNumbers(int startNumber, int endNumber)
        {
            if (endNumber < startNumber)
            {
                return 0;
            }
            else
            {
                return endNumber + RecursionSumCulculationOfNaturalNumbers(startNumber, endNumber - 1);
            }
        }
    }
}