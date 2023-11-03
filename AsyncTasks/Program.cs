namespace AsyncTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();

            prg.GetSumAsync(25, 15);

            Console.ReadKey();

        }

        public async void GetSumAsync(int firstNumber, int secondNumber)
        {
            int result = 0;
            Console.WriteLine("Метод поиска суммы стартовал");

            await Task.Run(() =>
            {
                result = GetSum(firstNumber, secondNumber);
            });

            Console.WriteLine($"{result}");
        }

        public int GetSum(int firstNumber, int secondNumber)
        {
            Task.Delay(2000).Wait();
            return firstNumber + secondNumber;
        }
    }
}