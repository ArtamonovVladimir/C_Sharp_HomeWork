namespace VladimirArtamonov
{
    public static class HomeWorkTask62
    {
        //Задача 62. Заполните спирально массив 4 на 4.
        //Например, на выходе получается вот такой массив:
        //1 2 3 4
        //12 13 14 5
        //11 16 15 6
        //10 9 8 7

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве:");
            int rowLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество колонок в массиве:");
            int columnLength = Convert.ToInt32(Console.ReadLine());
            int[,] twoDimensionalArray = new int[rowLength, columnLength];
            SpiralArray(twoDimensionalArray);
            Console.WriteLine("Спиральное заполнение массива:");
            PrintArray(twoDimensionalArray);
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
            //Console.WriteLine();
        }


        public static void SpiralArray(int[,] array)
        {
            int rowLength = array.GetLength(0),
                columnLength = array.GetLength(1),
                rowIndex = 0,
                columnIndex = 0,
                rowStart = 0,
                rowEnd = 0,
                columnStart = 0,
                columnEnd = 0;

            for (int number = 1; number <= array.GetLength(0) * array.GetLength(1); number++)
            {

                array[rowIndex, columnIndex] = number;
                if (rowIndex == rowStart && columnIndex < array.GetLength(1) - 1 - columnEnd)
                {
                    columnIndex++;
                }

                else if (rowIndex < array.GetLength(0) - 1 - rowEnd && columnIndex == array.GetLength(1) - 1 - columnEnd)
                {
                    rowIndex++;
                }
                else if (rowIndex == array.GetLength(0) - 1 - rowEnd && columnIndex > columnStart)
                {
                    columnIndex--;
                }
                else
                {
                    rowIndex--;
                }
                if (rowIndex == rowStart + 1 && columnIndex == columnStart && columnStart != array.GetLength(1) - columnEnd - 1)
                {
                    rowStart++;
                    rowEnd++;
                    columnStart++;
                    columnEnd++;
                }

            }
        }
    }

}
