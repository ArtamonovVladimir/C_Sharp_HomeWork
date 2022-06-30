namespace VladimirArtamnov
 {
    class HomeWork_Task_10
    {
        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }
        
        public static void Main(string[] args)
        {
            int number = GetRandomNumber(100,1000);
            string array = Convert.ToString(number);
            int secondChar = Convert.ToInt32(array[1].ToString());
            Console.WriteLine($"Вторым числом в трехзначном {number} является {secondChar}");

        }
    }
 }