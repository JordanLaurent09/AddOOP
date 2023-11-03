namespace Lesson0311
{
    // Задачи
    // Если версия старая - нужно подключить using System.Threading
    // и using System.Threading.Tasks
    // Threads - УСТАРЕЛИ. Все пользуются Tasks
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Один способ создать и запустить задачу
            //Task taskOne = new Task(() => { Console.WriteLine("Я задача 1"); });
            //Task taskTwo = new Task(() => { Console.WriteLine("Я задача 2"); });
            //Task taskThree = new Task(() => { Console.WriteLine("Я задача 3"); });
            //taskOne.Start();
            //taskTwo.Start();
            //taskThree.Start();
            //taskOne.Wait();
            //taskTwo.Wait();
            //taskThree.Wait();

            //// Другой способ создать и запустить задачу
            //Task taskFour = Task.Run(() => { Foo(); });
            //taskFour.Wait();



            Task task = new Task(Foo);
            Console.WriteLine(task.Status);
            Thread.Sleep(2000);
            Console.WriteLine(task.Status);
            task.Start();
            Console.WriteLine(task.Status);
            Thread.Sleep(2000);
            Console.WriteLine(task.Status);
            task.Wait();
            Console.WriteLine(task.Status);
            // Status - данное свойство показывает текущее состояние Task
        }


        public static void Foo()
        {
            Task task = Task.Factory.StartNew(() => { Console.WriteLine("Я вложенный поток"); Task.Delay(2000).Wait();});
            Task.Delay(1000).Wait();
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Поток - {i}");
                //Task.Delay(1000).Wait(); // Вместо метода Sleep() - Delay()
            }
        }
        
    }
}