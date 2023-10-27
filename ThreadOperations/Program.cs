using System.Threading.Channels;

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
    // CurrentThread - создает копию текущего потока, таким образом можно узнавать информацию о потоке
    // Name - имя потока, IsAlive - информация о том, работает ли поток
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3.

            Thread secondaryThread = new Thread(PrintNumbers);
            secondaryThread.Name = "Вторичный поток";

            secondaryThread.Priority = ThreadPriority.AboveNormal;
            secondaryThread.Start();




            // 2.

            //Thread secondaryThread = Thread.CurrentThread;
            //secondaryThread.Name = "Главный поток";

            //Console.WriteLine($"Работает ли текущий поток: {secondaryThread.IsAlive}");

            //Thread secondaryThread = new Thread(() =>
            //{
            //    Thread.Sleep(10000);
            //});
            //secondaryThread.Start();
            //Console.WriteLine(secondaryThread.IsAlive);

            //Thread.Sleep(12000);
            //Console.WriteLine(secondaryThread.IsAlive);

            //Thread thirdThread = new Thread(() => 
            //{ 
            //    Console.WriteLine("Strange");
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.WriteLine($"Вторичный поток: {i}");
            //        //Thread.Sleep(300);
            //    }
            //});
            //thirdThread.Name = "Третий поток на вывод числа";
            //thirdThread.Start();

            
            // 1.

            //Thread secondaryThread = new Thread(PrintNumbers);
            //secondaryThread.Start();

            ////secondaryThread.Join(); // Обеспечивает полное выполнение текущего потока

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.SetCursorPosition(30, i);
            //    Console.WriteLine($"Первичный поток: {i}");
            //    Thread.Sleep(250);

            //    if(i == 2)
            //    {
            //        secondaryThread.Interrupt();
            //    }
            //}
            //Thread secondaryThread = new Thread(ShowMessage);

            //secondaryThread.Start();

            //Console.WriteLine("message");
        }

        public static void PrintNumbers()
        {
            //for(int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine($"Вторичный поток: {i}");
            //    //Thread.Sleep(300);
            //}
            Thread myThread = Thread.CurrentThread;
            Console.WriteLine("Имя вторичного потока - " + myThread.Name);
            Thread.Sleep(10000);
        }
    }
}