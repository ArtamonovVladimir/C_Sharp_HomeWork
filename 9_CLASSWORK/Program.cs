namespace VladimirArtamonov
{
    public static class ClassWork9Task2
    {
        //Задача 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
        // Например, изначально массив выглядел вот так:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Новый массив будет выглядеть вот так:
        // 1 4 7 2
        // 5 81 2 9
        // 8 4 2 4


        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве:");
            int rowLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество колонок в массиве:");
            int columnLength = Convert.ToInt32(Console.ReadLine());
            int[,] twoDimensionalArray = new int[rowLength, columnLength];
            RandomFillDimensionalArray(twoDimensionalArray);
            Console.WriteLine("Вводный массив:");
            PrintArray(twoDimensionalArray);
            SquareOfEvenIndex(twoDimensionalArray);
            Console.WriteLine("Итоговый массив:");
            PrintArray(twoDimensionalArray);
        }

        public static void RandomFillDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
            }
        }

        public static void PrintArray(int[,] incomingArray)
        {
            for (int i = 0; i < incomingArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomingArray.GetLength(1); j++)
                {
                    Console.Write($"{incomingArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void SquareOfEvenIndex(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
                    {
                        array[i, j] = array[i, j] * array[i, j];
                    }
                }
            }
        }

    }
}
// public static class ClassWork9Task1
// {
//         //Задача 1. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.



//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Введите количество строк в массиве:");
//             int rowLength = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите количество колонок в массиве:");
//             int columnLength = Convert.ToInt32(Console.ReadLine());
//             int[,] twoDimensionalArray = new int[rowLength, columnLength];
//             RandomFillDimensionalArray(twoDimensionalArray);
//             Console.WriteLine("Вводный массив:");
//             PrintArray(twoDimensionalArray);
//             int[,] finalArray = FindMinElement(twoDimensionalArray);
//             Console.WriteLine("Итоговый массив:");
//             PrintArray(finalArray);
//         }

//         public static void RandomFillDimensionalArray(int[,] array)
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     array[i, j] = new Random().Next(1, 10);
//                 }
//             }
//         }

//         public static void PrintArray(int[,] incomingArray)
//         {
//             for (int i = 0; i < incomingArray.GetLength(0); i++)
//             {
//                 for (int j = 0; j < incomingArray.GetLength(1); j++)
//                 {
//                     Console.Write($"{incomingArray[i, j]} ");
//                 }
//                 Console.WriteLine();
//             }
//         }

//         public static int[,] FindMinElement(int[,] array)
//         {
//             int minElement = array[0, 0],
//                 minI = 0,
//                 minj = 0;
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     if (minElement > array[i, j])
//                     {
//                         minI = i;
//                         minj = j;
//                         minElement = array[i, j];
//                     }
//                 }
//             }
//             Console.WriteLine($"minI = {minI} minJ = {minj} и MIN = {minElement}");
//             int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     if (i < minI && j < minj)
//                     {
//                         newArray[i, j] = array[i, j];
//                     }
//                     else if (i > minI && j > minj)
//                     {
//                         newArray[i - 1, j - 1] = array[i, j];
//                     }
//                     else if (i < minI && j > minj)
//                     {
//                         newArray[i, j - 1] = array[i, j];
//                     }
//                     else if (i > minI && j < minj)
//                     {
//                         newArray[i - 1, j] = array[i, j];
//                     }

//                 }
//             }
//             return newArray;
//         }

//     }
// }