namespace ThreadOperations
{
    // Работа с потоками
    // Класс Thread отвечает за распараллеливание потока
    // Объект класса Thread - новый поток
    // Через отладку параллельные потоки НЕ ОТСЛЕЖИВАЮТСЯ!!!
    // Метод Start() - начинает работу потока
    // Метод Join() - ожидает завершения работы потока
    // Метод Sleep() - задержка потока, в котором он вызывается
    // Метод Interrupt() - прерывание выполнения потока
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread secondaryThread = new Thread(PrintNumbers);
            secondaryThread.Start();

            //secondaryThread.Join(); // Обеспечивает полное выполнение текущего потока

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(30, i);
                Console.WriteLine($"Первичный поток: {i}");
                Thread.Sleep(250);

                if(i == 2)
                {
                    secondaryThread.Interrupt();
                }
            }
            //Thread secondaryThread = new Thread(ShowMessage);

            //secondaryThread.Start();

            //Console.WriteLine("message");
        }

        public static void PrintNumbers()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Вторичный поток: {i}");
                //Thread.Sleep(300);
            }
        }
    }
}