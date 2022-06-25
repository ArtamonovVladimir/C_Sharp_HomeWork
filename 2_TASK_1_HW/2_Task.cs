// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите сколько будет всего чисел, для определения из них максимального и минимального: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
double[] array = new double[lastNumber];
int index = 0;
int lengthOfArray = array.Length;
Console.Write($"Введите {index + 1} целое число: ");
array[index] = Convert.ToDouble(Console.ReadLine());
double maxNumber = array[index];
double minNumber = array[index];
index++;
while (index < lengthOfArray)
{
    Console.Write($"Введите {index + 1} целое число: ");
    array[index] = Convert.ToDouble(Console.ReadLine());
    if (maxNumber < array[index]) maxNumber = array[index];
    if (minNumber > array[index]) minNumber = array[index];
    index++;
}
Console.WriteLine($"Максимальное число в Вашем ряду составляет {maxNumber}");
Console.Write($"Минимальное число в Вашем ряду составляет {minNumber}");
