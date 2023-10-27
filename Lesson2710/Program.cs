namespace Lesson2710
{
    // Продолжение работы с ThreadOperations
    // Ключевое слово lock - блокировка доступа
    internal class Program
    {
        private static readonly object _lockObject = new object();
        private static int _counter = 0;
        static void Main(string[] args)
        {
            Thread firstThread = new Thread(IncrementCounter);
            Thread secondThread = new Thread(IncrementCounter);

            firstThread.Start();
            secondThread.Start();

            firstThread.Join();
            secondThread.Join();

            Console.WriteLine("Оба потока завершили работу.\nКонечное состояние счетчика: " + _counter);
        }

        public static void IncrementCounter()
        {
            for(int i = 0; i < 100000; i++)
            {
                lock (_lockObject)
                {
                    _counter++;
                }
            }
        }
    }
}